using HarmonyLib;
using UnityEngine;

namespace FlickeringNeonMute
{
    class HarmonyPatches
    {
        [HarmonyPatch(typeof(FlickeringNeonSign), "SetOn")]
        private class PFlickeringNeonSign
        {
            internal static void Postfix(ref float ____sparksVolume)
            {
                ____sparksVolume = 0.0F;
            }
        }
    }
}
    