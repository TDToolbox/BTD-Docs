using Assets.Scripts.Utils;
using Harmony;
using MelonLoader;
using NKHook6.Api.Events;
using NKHook6.Api.Events._TimeManager;

namespace BetterFastForward
{
    public class Main : MelonMod    //Make sure you have   : MelonMod   here otherwise your mod won't work
    {
        public override void OnApplicationStart() //Default MelonLoader patch that gets executed when BTD6 starts
        {
            base.OnApplicationStart();
            HarmonyInstance.Create("TD Toolbox.Better FastForward").PatchAll();

            MelonLogger.Log("Better FastForward loaded!");  //Post a message to console to tell the user your mod has loaded
        }


        //This is an example of using Harmony to patch in game methods
        //This example mod sets fast forward speed to whatever you change newSpeed to be.
        //Unlike the Better FastForward mod in NKHook6 example mods, this one does NOT have a settings file
        //This means that you have to to manually set fast forward speed in code whevenver you want to change it.
        //Settings files are difficult to code and configure properly, which is why NKHook6 is so useful, so you don't have to make it yourself.
        //You can get more info on NKHook6 here: https://github.com/TDToolbox/BTD-Docs/tree/master/NK-Unity%20Engine/Btd6/NKHook6
        [HarmonyPatch(typeof(TimeManager), "SetFastForward")]
        public class FastForward_Patch
        {
            [HarmonyPostfix]
            internal static void Postfix()
            {
                if (TimeManager.gamePaused || TimeManager.coopPaused)   //exit this method if game is paused
                    return;

                float newSpeed = 10;
                TimeManager.compromisedFastFowardRate = (int)newSpeed; //Set current speed. Convert newSpeed from a float to int
                TimeManager.maxSimulationStepsPerUpdate = newSpeed;    //Set max speed to the same as new current speed
            }

        }
    }
}
