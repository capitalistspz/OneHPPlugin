using HarmonyLib;

namespace OneHPPlugin.patches;

public class MaxHealthPatch
{
    // Both patches modify the argument setting HP, so that the max is 1 HP
    
    [HarmonyPatch(typeof(UIEnergyBar), nameof(UIEnergyBar.SetPermanentHP), MethodType.Normal), HarmonyPrefix]
    public static void MaxHPUI(ref float count)
    {
        count = 1.0f;
    }
    [HarmonyPatch(typeof(PlayerGlobal), nameof(PlayerGlobal.SetMaxHP), MethodType.Normal), HarmonyPrefix]
    public static void MaxHPPlayer(ref int hp)
    {
        hp = 1;
    }
    
}