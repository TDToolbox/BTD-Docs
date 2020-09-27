using Assets.Scripts.Utils;
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
            EventRegistry.subscriber.register(this.GetType());  //Subscribe to NKHook6's custom event system

            NKHook6.Logger.Log("Better FastForward loaded!");  //Post a message to console to tell the user your mod has loaded
        }


        //This is an example of using one of NKHook6's custom events
        //This example mod gets reads the settings file every time you turn on fast forward.
        //This means you can change the fast forward speed in your settings and have it update in game!
        [EventAttribute("TimeManager.SetFastForwardEvent.Post")]
        public static void ChangeFastForward(TimeManager.SetFastForwardEvent.Post e)
        {
            if (TimeManager.gamePaused || TimeManager.coopPaused)   //exit this method if game is paused
                return;

            Settings settings =  NKHook6.Api.Utilities.JsonUtils.Load<Settings>();  //load settings from file
            
            TimeManager.compromisedFastFowardRate = (int)settings.newSpeed; //Set current speed. Convert newSpeed from a float to int
            TimeManager.maxSimulationStepsPerUpdate = settings.newSpeed;    //Set max speed to the same as new current speed
        }
    }
}
