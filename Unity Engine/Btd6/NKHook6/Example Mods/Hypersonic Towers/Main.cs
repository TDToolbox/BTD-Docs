using Harmony;
using MelonLoader;
using NKHook6;
using NKHook6.Api.Events;
using static NKHook6.Api.Events._Weapons.WeaponEvents;

namespace Hypersonic_Towers
{
    public class Main : MelonMod
    {
        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            HarmonyInstance.Create("TDToolbox.Hypersonic Towers").PatchAll();
            EventRegistry.subscriber.register(this.GetType());
            Logger.Log("Hypersonic Towers has finished loading");
        }

        [EventAttribute("Weapon.InitialiseEvent.Post")]
        public static void WeaponInitialiseEvent(InitialiseEvent.Post e)
        {
            e.instance.weaponModel.rate = 0;
        }
    }
}
