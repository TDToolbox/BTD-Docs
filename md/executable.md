# Executable files

Executable files are [binary files](Terms/binary.md) that contain compiled code.

## Table of contents

- [Executable files](#executable-files)
  - [Table of contents](#table-of-contents)
  - [Types of executable files](#types-of-executable-files)
  - [Executable file formats](#executable-file-formats)
    - [The PE format (.exe, .dll)](#the-pe-format-exe-dll)
      - [RVA's and VA's](#rvas-and-vas)
      - [Export Directory](#export-directory)
      - [Getting Exports from an existing DLL](#getting-exports-from-an-existing-dll)
      - [Import directory](#import-directory)
      - [DLL Hijacking](#dll-hijacking)
    - [The ELF File format (.so, .elf, .bin)](#the-elf-file-format-so-elf-bin)

## Types of executable files

The most commonly known executable file is the Windows portable executable file (.exe).
Windows Dynamic Link Libraries (.dll)'s are also executables, they're libraries that can be loaded whilst a program is running.
Unix like systems (Android, Linux, OSX) don't have .exe's, almost anything file is executable. Its equivalent to a .dll is a .so file.

## Executable file formats

### The PE format (.exe, .dll)

The full format specification can be found [here](https://docs.microsoft.com/en-us/windows/win32/debug/pe-format).  

If you want an easy way to view & dissect PE files, use [CFF Explorer](https://ntcore.com/?page_id=388) as a part of the explorer suite.

Useful parts of the PE include:  

1. [COFF Header](https://docs.microsoft.com/en-us/windows/win32/debug/pe-format#coff-file-header-object-and-image) - Contains the number of sections
2. [The Optional Header](https://docs.microsoft.com/en-us/windows/win32/debugpe-format#optional-header-windows-specific-fields-image-only) - Specifically the ImageBase.  
3. [Section Headers](https://docs.microsoft.com/en-us/windows/win32/debug/pe-format#section-table-section-headers) - Contains the RVA/Offset of every section.
4. [The Optional Header Data Directories](https://docs.microsoft.com/en-us/windows/win32/debug/pe-format#optional-header-data-directories-image-only) - Contains the Import and [Export](#export-directory) directory

#### RVA's and VA's

**Offset**: How many bytes offset the segment is from the start of the file. This is usually used when dealing with modifying *files*.  
Relative Virtual Address (**RVA**):  How many bytes offset the segment is once its loaded into memory. This is usually used when dealing with modifying *memory*  
Virtual Address (**VA**): The Virtual Memory address of a segment of memory. This is usually used when dealing with *pointers*

#### Export Directory

Exporting a method allows a programmer to use a DLL without linking. In simple terms, you can use code without updating the .dll at the same time. Here's an example of how that may work in C:  
Note on Linux with GCC/Clang, every method is public by default.  

```c
#include <stdio.h>

#define EXPORT __declspec(dllexport)

EXPORT void printMessage(const char* msg) {
    printf(msg, "Message Printed %s");
}
```

If you compile the above code as a .dll, in another library you should be able to write the following code provided you have a .lib to link at the time.

```c
#define IMPORT __declspec(dllimport)

IMPORT void printMessage(const char* msg);

void main() {
    printMessage("Hi");
}
```

#### Getting Exports from an existing DLL

Normally you would still need a .lib for a C++ compiler to link successfully, however in the case you don't have the source, there's still a way.  

This tutorial will be for Windows x64. Make sure Visual Studio is installed with the Visual C++ Compiler and "x64 native tools"  
In the start menu, open "x64 native tools command prompt for VS 2019" or whatever your version  
Navigate to the DLL of your choice with `CD /D <YourFolder>`, eg  `CD /D "C:\SteamLibrary\steamapps\common\BloonsTD6"`  
Type `dumpbin /EXPORTS <YourExecutable>`, eg `dumpbin /EXPORTS "GameAssembly.dll"`  
The program should output something similar to:  

```dumpbin
    ordinal hint RVA      name

          1    0 001CAD80 CloseZStream
          2    1 001CAE30 CreateZStream
          3    2 001CAF50 Flush
          ...
```

This gives you the RVA and the symbol name.  
From here, there's a few things you can do. You can create a def file that looks like

```def
LIBRARY   GAMEASSEMBLY
EXPORTS
   CloseZStream
   CreateZStream
   Flush
   ...
```

You should be able to link against this file (Untested) to use the symbol  
Alternatively (Not Recommended) Its possible to use a function pointer to call an exported DLL's function.  

```cpp
#include <Windows.h>

void onInject(){
    HMODULE hGameAsm = GetModuleHandle(L"GameAssembly.dll");
    void(*CloseZStream)() = (void(*)())(GetProcAddress(hGameAsm, "CloseZStream"));
    CloseZStream();
}


BOOL APIENTRY DllMain( HMODULE hModule, DWORD  ul_reason_for_call, LPVOID lpReserved)
{
    switch (ul_reason_for_call) {
    case DLL_PROCESS_ATTACH:
        CreateThread(NULL, NULL, (LPTHREAD_START_ROUTINE)onInject, hModule, NULL, NULL);
    case DLL_PROCESS_DETACH:
        break;
    }
    return TRUE;
}
```

If your curious, here's how you can implement most of this yourself. Here's an example: (Don't use this code)

```cpp
#include <Windows.h>
#include <Psapi.h>
#include <vector>
#include <string>

HANDLE GetProcHandle(std::basic_string<TCHAR> procName) {

    // Enumerate all proccesses

    std::vector<DWORD> ProcIds;
    DWORD ProcIdsSize = 0;
    DWORD bytesNeeded = 0;

    while (bytesNeeded / sizeof(DWORD) == ProcIdsSize) {
        ProcIdsSize += 512;

        ProcIds = std::vector<DWORD>(ProcIdsSize);

        if (EnumProcesses(
            ProcIds.data(),
            ProcIdsSize * sizeof(DWORD),
            &bytesNeeded
        ) == 0) {
            DWORD ErrorCode = GetLastError();
            // Output to your error logger here
        }

    }

    // Now loop over them

    for (int i = 0; i < bytesNeeded / sizeof(DWORD); i++) {

        // This is the default value for unaccessable proccesses anyway.
        TCHAR ProcName[MAX_PATH] = TEXT("<unknown>");

        HANDLE hproc = OpenProcess(
            PROCESS_QUERY_INFORMATION | PROCESS_VM_READ | PROCESS_VM_OPERATION,
            FALSE, // Do not inherit handle
            ProcIds[i]
        );

        if (hproc != NULL) {
            GetModuleBaseName(
                hproc,
                NULL, // Base = Name of exe
                ProcName,
                MAX_PATH
            );
        }

        std::basic_string<TCHAR> ProcNameStr = ProcName;

        if (ProcNameStr == procName) {
            if (hproc != NULL) {
                CloseHandle(hproc);

                hproc = OpenProcess(
                    PROCESS_ALL_ACCESS,
                    FALSE, // Do not inherit handle
                    ProcIds[i]
                );

                if (hproc == NULL) {
                    DWORD error = GetLastError();
                    // Output to your error logger here
                }

                return hproc;
            }
        }
    }

    // Print a warning to your error logger here, the proc was not found!

    return INVALID_HANDLE_VALUE;
}

HMODULE GetModuleHandle(HANDLE HProc, std::basic_string<TCHAR> moduleName) {

    // Enumerate all modules

    std::vector<HMODULE> Modules;
    DWORD ModulesSize = 0;
    DWORD bytesNeeded = 0;

    while (bytesNeeded / sizeof(DWORD) == ModulesSize) {
        ModulesSize += 512;

        Modules = std::vector<HMODULE>(ModulesSize);

        if (EnumProcessModules(
            HProc,
            Modules.data(),
            ModulesSize * sizeof(DWORD),
            &bytesNeeded
        ) == 0) {
            DWORD ErrorCode = GetLastError();
            // Output to your error logger here
        }

    }

    // This is the default value for unaccessable modules anyway.
    TCHAR ModName[MAX_PATH] = TEXT("<unknown>");

    for (int i = 0; i < bytesNeeded / sizeof(HMODULE); i++) {

        GetModuleBaseName(
            HProc,
            Modules[i],
            ModName,
            MAX_PATH
        );

        std::basic_string<TCHAR> ModNameStr = ModName;

        if (ModNameStr == moduleName) {
            return Modules[i];
        }

    }

    // Print a warning to your error logger here, the module was not found!
    return NULL;
}

BOOL dumpSymbols(std::map<std::string, uint64_t>& ret, PBYTE peFile) {

    PIMAGE_DOS_HEADER dosHeader = reinterpret_cast<PIMAGE_DOS_HEADER>(peFile);

    if (dosHeader->e_magic != IMAGE_DOS_SIGNATURE) {
        return ERROR_BAD_FORMAT;
    }

    PIMAGE_NT_HEADERS64 ntHeaders = reinterpret_cast<PIMAGE_NT_HEADERS64>(peFile + dosHeader->e_lfanew);

    if (ntHeaders->Signature != IMAGE_NT_PEHEADER_SIGNATURE
        || ntHeaders->OptionalHeader.Magic != IMAGE_NT_OPTIONAL_HDR64_MAGIC) {
        return ERROR_BAD_FORMAT;
    }

    PIMAGE_EXPORT_DIRECTORY exportDir =
    reinterpret_cast<PIMAGE_EXPORT_DIRECTORY>(peFile +
        ntHeaders->OptionalHeader.DataDirectory[IMAGE_DIRECTORY_ENTRY_EXPORT].VirtualAddress);

    uint64_t offset = (uint64_t)exportDir - (uint64_t)peFile;

    if (ntHeaders->OptionalHeader.NumberOfRvaAndSizes <= IMAGE_DIRECTORY_ENTRY_EXPORT) {
        //There will be no exports here.
        return ERROR_NOT_SUPPORTED;
    }

    for (int i = 0; i < exportDir->NumberOfNames; i++) {

        DWORD rva = (*reinterpret_cast<PDWORD>(peFile +
            exportDir->AddressOfFunctions + i * sizeof(rva)));

        DWORD namePointer = exportDir->AddressOfNames + (i * sizeof(namePointer));

        std::string methodName = std::string(reinterpret_cast<char*>
            (peFile + (*reinterpret_cast<PDWORD>(peFile + namePointer))));

        std::string xethodName = std::string((char*)
            (peFile + (*(DWORD*)(peFile + namePointer))));

        ret.insert(std::pair <std::string, uint64_t>(methodName, rva));

    }

    return ERROR_SUCCESS;
}

bool IsInitialized = false;

void onInject(){
    IsInitialized = true;

    auto hGame = GetProcHandle(L"BloonsTD6.exe");
    auto hDll = GetModuleHandle(hGame, L"GameAssembly.dll");
    auto symbols = std::map<std::string, uint64_t>();
    auto retCode = dumpSymbols(symbols, (PBYTE)(hDll));

    void(*CloseZStream)() = (void(*)())(symbols["CloseZStream"]);
    CloseZStream();

}

BOOL APIENTRY DllMain( HMODULE hModule, DWORD  ul_reason_for_call, LPVOID lpReserved)
{
    switch (ul_reason_for_call) {
    case DLL_PROCESS_ATTACH:
        if(IsInitialized){
            CreateThread(NULL, NULL, (LPTHREAD_START_ROUTINE)onInject, hModule, NULL, NULL);
        }

    case DLL_PROCESS_DETACH:
        break;
    }
    return TRUE;
}

```

#### Import directory

The Import directory contains every instance of a `__declspec(dllimport)` function.
This includes ones use implicitly in headers. (Eg, when using the Windows API.)  
For example, it may contain `Sleep` (Hint `058B`) from `KERNEL32.dll`

There are some programs that can modify a DLL's import directory to load your own DLL, similar to [DLL Hijacking](#dll-hijacking)

#### DLL Hijacking

This will be done later...

### The ELF File format (.so, .elf, .bin)

I don't know too much about the ELF file format. It has a different concept of RVA's/VA's/Offsets.  
Information of the ELF file format can be found [here](https://en.wikipedia.org/wiki/Executable_and_Linkable_Format)
