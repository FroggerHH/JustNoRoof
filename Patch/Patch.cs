using HarmonyLib;
using static JustNoRoof.Plugin;

namespace JustNoRoof;

[HarmonyPatch]
public class Patch
{
    [HarmonyPatch(typeof(CraftingStation), nameof(CraftingStation.CheckUsable)), HarmonyPrefix]
    public static bool Prefix(ref bool __result)
    {
        if (enabledConfig.Value == true)
        {
            __result = true;
            return false;
        }

        return true;
    }
}