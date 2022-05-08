using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using OneHPPlugin.patches;

namespace OneHPPlugin
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        internal static Harmony Harmony;
        internal static ManualLogSource Log;
        private void Awake()
        {
            Harmony = new Harmony(PluginInfo.PLUGIN_GUID);
            Log = Logger;
            
            ApplyPatches();
            
            Log.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");
        }

        private void ApplyPatches()
        {
            Harmony.PatchAll(typeof(MaxHealthPatch));
        }
    }
}
