using System.Reflection;
using BepInEx;
using BepInEx.Configuration;
using HarmonyLib;

namespace JustNoRoof;

[BepInPlugin(ModGUID, ModName, ModVersion)]
internal class Plugin : BaseUnityPlugin
{
    internal const string ModName = "JustNoRoof", ModVersion = "1.0.0", ModGUID = "com.Frogger." + ModName;
    internal static ConfigEntry<bool> enabledConfig;
    internal static Plugin _self;

    private void Awake()
    {
        _self = this;

        enabledConfig = Config.Bind("General", "Enabled", true, "Enable/disable the mod.");

        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), ModGUID);
    }
}