using NKHook6.Api;

namespace Random_Stronger_Bloons
{
    public class Settings : ModSettings
    {
        public int chanceToBeStronger_zeroToOneHundred { get; set; } = 20;
        public int maxRandomChange { get; set; } = 5;
        public bool allowCamoRandoms { get; set; } = true;
        public bool allowRegenRandoms { get; set; } = true;
        public bool allowFortifiedRandoms { get; set; } = true;
    }
}