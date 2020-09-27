using Assets.Scripts.Models.Bloons;
using Harmony;
using MelonLoader;
using NKHook6.Api.Events;
using NKHook6.Api.Utilities;
using System;
using static NKHook6.Api.Events._Bloons.BloonEvents;
using Logger = NKHook6.Logger;

namespace Random_Stronger_Bloons
{
    class Main : MelonMod
    {
        public static Settings settings;

        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            HarmonyInstance.Create("TD Toolbox.Random Stronger Bloons").PatchAll();
            EventRegistry.subscriber.register(this.GetType());
            Logger.Log("Random Stronger Bloons has finished loading");
        }


        [EventAttribute("Bloon.InitialiseEvent.Pre")]
        public static void BloonSpawnedEvent(InitialiseEvent.Pre e)
        {
            settings = JsonUtils.Load<Settings>();

            int next = new Random().Next(0, 100);
            if (next > settings.chanceToBeStronger_zeroToOneHundred)
                return;

            BloonModel nextBloon = GetNextBloon(e.model.name);

            if (nextBloon != null)
                e.model = nextBloon;
        }


        public static BloonModel GetNextBloon(string currentBloon)
        {
            var allBloonTypes = BloonUtils.GetAllBloonTypes();

            int maxRand = settings.maxRandomChange - 1; //subtracting 1 so it will always give us the nextbloon. Otherwise random could give us 1 bloon higher than max set value
            if (maxRand < 0)
                maxRand = 0;


            var rand = new Random().Next(0, maxRand);
            var nextBloonNum = BloonUtils.GetBloonIdNum(currentBloon); //Giving it initial value of current bloon

            if (nextBloonNum + rand > allBloonTypes.Count - 2) //subtracting 2 to avoid test bloon
                nextBloonNum = allBloonTypes.Count - 2;  //subtracting 2 to avoid test bloon
            else
                nextBloonNum += rand;

            var nextBloon = BloonUtils.GetNextStrongestBloon(allBloonTypes[nextBloonNum]);

            return BloonUtils.RemoveBloonStatus(nextBloon.name, settings.allowCamoRandoms,
                settings.allowFortifiedRandoms, settings.allowRegenRandoms);
        }
    }
}
