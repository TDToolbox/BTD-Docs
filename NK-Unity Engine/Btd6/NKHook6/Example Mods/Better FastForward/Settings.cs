using Newtonsoft.Json;
using NKHook6.Api;
using NKHook6.Api.Utilities;
using System;
using System.IO;

namespace BetterFastForward
{
    public class Settings : ModSettings
    {
        public float newSpeed { get; set; } = 10;
    }
}