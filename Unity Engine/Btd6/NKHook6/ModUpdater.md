# Mod Update Notifier
Ever wish you could notify all of your loyal fans whenever you released an update? Well now you can! NKHook6 comes with a built in update notifier. If you release an update it will let all of your users know IN GAME! Now you can guarentee that everyone is always playing the latest and greatest verson of your mod. Here's how you do it:

1. Create a Github account.
2. Create a repository on Github. Can be named whatever you want
3. In that repository create a text file. Inside that text file put your version number. Heres an example: 

![github version example](https://media.discordapp.net/attachments/619054151967703061/759621686139027506/unknown.png?width=415&height=128)
You can use whatever you want for version numbers as long as there are actual numbers. NKHook6 will ignore any character that is not a number

4. In the top right corner you will see a button with the word "Raw" on it. Click that button
![raw button](https://media.discordapp.net/attachments/619054151967703061/759622250344349706/unknown.png?width=292&height=109)

5. Copy the url to that page.
6. We're just about done. Go to your mod, Click on "Properties" in the Solution Explorer, then click on AssemblyInfo. Now paste this line somwhere in that file
`[assembly: NKHook6.LatestVersionURL(typeof(YOUR_PROJ_NAMESPACE.Main), "YOUR_URL_HERE")]`

To explain this line of code:
- replace `YOUR_PROJ_NAMESPACE` to the namespace for your mod. For example, NKHook6's namespace is `NKHook6`. `Main` should be your main project file, or whereever your program starts in. If you didn't rename your files when you made your project it might be called `Class1` for you.
- replace `YOUR_URL_HERE` with the url you copied from your github raw page

Now you're done. NKHook6 will automatically check your mod for updates. Just make sure you update the version number in that text file whenever you release a new update.

### Still have questions?
Join our [discord server](https://discord.gg/VADMF2M) to get more assistance
