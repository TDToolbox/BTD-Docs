using Assets.Scripts.Utils;
using MelonLoader;
using NKHook6;
using NKHook6.Api.Events;
using NKHook6.Api.Events._TimeManager;

namespace BetterFastForward
{
    public class Main : MelonMod
    {
        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            EventRegistry.subscriber.register(this.GetType());

            NKHook6.Logger.Log("Better FastForward loaded!");
        }


        [EventAttribute("TimeManagerSetFastForwardEvent.Post")]
        public static void ChangeFastForward(TimeManagerSetFastForwardEvent.Postfix e)
        {
            if (TimeManager.gamePaused || TimeManager.coopPaused)
                return;

            Settings settings =  NKHook6.Api.Utilities.JsonUtils2.Load<Settings>();
            
            TimeManager.compromisedFastFowardRate = (int)settings.newSpeed;
            TimeManager.maxSimulationStepsPerUpdate = settings.newSpeed;
        }
    }
}
