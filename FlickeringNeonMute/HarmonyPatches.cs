using HarmonyLib;
using UnityEngine;

namespace FlickeringNeonMute
{
    class HarmonyPatches
    {
        [HarmonyPatch(typeof(FlickeringNeonSign), "SetOn")]
        private class PFlickeringNeonSign
        {
            internal static void Postfix(ref AudioSource ____audioSource)
            {
                ____audioSource.volume = 0;
            }
        }
    }
}
    