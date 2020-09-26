using NKHook6.Api;

namespace BetterFastForward
{
    //This file is an example of how to set up ModSettings for your mod
    //You can use this to very easily add settings to your mods that are stored locally
    //in your mod's folder. Can be used to change mod settings in game and out of game
    //This will be saved to file so you can change it out of game.
    public class Settings : ModSettings
    {
        public float newSpeed { get; set; } = 10;   // A variable I set for speed. Can be changed in "BTD6/Mods/Better FastForward/settings.json"
    }
}