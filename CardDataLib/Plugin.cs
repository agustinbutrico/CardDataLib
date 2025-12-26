using CardDataLib.Corrections;
using BepInEx;
using CardsShared;
using HarmonyLib;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace CardDataLib
{
    [BepInPlugin("AgusBut.CardDataLib", "CardDataLib", "1.0.1")]
    public class Plugin : BaseUnityPlugin
    {
        public static Plugin Instance { get; private set; }
        public static BepInEx.Logging.ManualLogSource Log { get; private set; }

        public static class CardDisplayDataCollection
        {
            public static List<CardDisplayData> AllCards { get; } = new List<CardDisplayData>();
        }

        public static event Action OnCardSyncComplete;
        internal static void RaiseOnCardSyncComplete()
        {
            OnCardSyncComplete?.Invoke();
        }

        private void Awake()
        {
            Instance = this;
            Log = base.Logger;

            var harmony = new Harmony("AgusBut.CardDataLib");
            harmony.PatchAll();

            CardDataLibAPI.LoadAllCards(); // Always needed for card data

            SceneManager.activeSceneChanged += OnActiveSceneChanged;

            Logger.LogInfo("CardDataLib loaded successfully.");
        }

        private void OnActiveSceneChanged(Scene oldScene, Scene newScene)
        {
            if (newScene.name == "MainMenu")
            {
                CardDataLibAPI.AttachSpritesToCards(); // Attach sprites that exist in the main menu

                Instance.StartCoroutine(WaitThenCorrectMainMenuCards());
            }

            if (newScene.name == "GameScene")
            {
                CardsInSceneCorrector corrector = new CardsInSceneCorrector();
                corrector.CorrectGameSceneCards();

                CardDataLibAPI.AttachSpritesToCards(); // Attach sprites that only exist in-game

                RaiseOnCardSyncComplete();
            }
        }

        private IEnumerator WaitThenCorrectMainMenuCards()
        {
            while (GameObject.Find("Canvas/UpgradeMenu/SlidingScreen") == null)
                yield return null;

            CardsInSceneCorrector corrector = new CardsInSceneCorrector();
            corrector.CorrectMainMenuCards();
            UpgradeButtonFixer.FixAllButtons();
        }
    }
}
