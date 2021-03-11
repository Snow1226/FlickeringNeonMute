using HarmonyLib;
using IPA;
using System.Reflection;
using IPALogger = IPA.Logging.Logger;

namespace FlickeringNeonMute
{
    [Plugin(RuntimeOptions.SingleStartInit)]
    public class Plugin
    {
        internal static IPALogger Log { get; private set; }

        private readonly Harmony _harmony;
        private const string HarmonyID = "com.meivyn.flickeringneonmute";

        [Init]
        public Plugin(IPALogger logger)
        {
            Log = logger;
            _harmony = new Harmony(HarmonyID);
        }

        [OnStart]
        public void OnApplicationStart()
        {
            _harmony.PatchAll(Assembly.GetExecutingAssembly());
        }

        [OnExit]
        public void OnApplicationQuit()
        {

        }

    }
}
