using BepInEx;
using HarmonyLib;

namespace KillerDoug
{
    [BepInPlugin("gobo.killerdoug", "KillerDoug", "1.0.0")]
    public class Plugin : BaseUnityPlugin
    {
        void Start()
        {
            Harmony.CreateAndPatchAll(GetType().Assembly, "gobo.killerdoug");
        }
    }
}
