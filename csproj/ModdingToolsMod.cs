using UnityEngine;
using HarmonyLib;

public class ModdingToolsMod : IModApi
{
    public void InitMod(Mod mod)
    {
        DebugManager.PrintDebugMessage("InitMod called");

        var harmony = new Harmony("dx.jiry.moddingtoolsmod");
        harmony.PatchAll();

        DebugManager.PrintDebugMessage("Harmony patches applied");
    }
}
