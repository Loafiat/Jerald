﻿using BepInEx;
using BepInEx.Logging;

namespace Jerald
{
    [BepInPlugin("crafterbot.gorillatag.computer", "Jerald", "1.0.0")]
    public class Main : BaseUnityPlugin
    {
        public static ManualLogSource Logger;

        private void Start()
        {
            Logger = base.Logger;
            PageManager.RegisterPages();
            HarmonyLib.Harmony.CreateAndPatchAll(typeof(Main).Assembly);
        }
    }
}