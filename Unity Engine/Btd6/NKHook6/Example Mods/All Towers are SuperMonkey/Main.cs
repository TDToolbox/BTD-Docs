using Assets.Scripts.Unity;
using Assets.Scripts.Unity.UI_New.InGame;
using Harmony;
using MelonLoader;
using NKHook6;
using NKHook6.Api.Enums;
using NKHook6.Api.Events;
using NKHook6.Api.Utilities;
using static NKHook6.Api.Events._Towers.TowerEvents;

namespace All_Towers_Are_Supermonkey
{
    class Main : MelonMod
    {
        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            HarmonyInstance.Create("TDToolbox.All Towers are SuperMonkey").PatchAll();
            EventRegistry.subscriber.register(this.GetType());
            Logger.Log("All_Towers_are_SuperMonkey has finished loading");
        }

        [EventAttribute("Tower.InitialiseEvent.Pre")]
        public static void TowerInitialiseEvent(InitialiseEvent.Pre e)
        {
            e.model = TowerUtils.GetTower(DefaultTowerIds.SuperMonkey);
        }
    }
}
