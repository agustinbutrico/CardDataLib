using CardDataLib.Corrections;
using CardsShared;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace CardDataLib
{
    public static partial class CardDataLibAPI
    {
        private static readonly Dictionary<string, Sprite> _spriteCache = new Dictionary<string, Sprite>();

        private static Sprite FindSpriteByName(string spriteName)
        {
            if (_spriteCache.TryGetValue(spriteName, out var sprite))
                return sprite;

            foreach (var s in Resources.FindObjectsOfTypeAll<Sprite>())
            {
                if (s.name == spriteName)
                {
                    _spriteCache[spriteName] = s;
                    return s;
                }
            }

            return null;
        }

        public static void AttachSpritesToCards()
        {
            var missingSprites = new HashSet<string>();

            foreach (var card in Plugin.CardDisplayDataCollection.AllCards)
            {
                var sprite = FindSpriteByName(card.SpriteName);
                if (sprite != null)
                    card.Sprite = sprite;
                else
                    if (!string.IsNullOrWhiteSpace(card.SpriteName))
                    missingSprites.Add(card.SpriteName);
            }
        
            if (missingSprites.Count > 0)
                if (missingSprites.Count == 1)
                    Plugin.Log.LogInfo($"The sprite {missingSprites.First()} was not found in the current scene.");
                else
                    Plugin.Log.LogInfo($"The sprites {string.Join(", ", missingSprites)} were not found in the current scene.");
        }
        public static void LoadAllCards()
        {
            if (Plugin.CardDisplayDataCollection.AllCards.Count == 0)
                CardData.CardsRegisterManager.RegisterAllCards();

            Plugin.Log.LogInfo($"Loaded {Plugin.CardDisplayDataCollection.AllCards.Count} cards.");
        }

        public static List<CardDisplayData> GetAllCards() => Plugin.CardDisplayDataCollection.AllCards.ToList();

        public static List<CardDisplayData> FilterCards(
            Category? category = null,
            Subcategory? subcategory = null,
            AcquisitionType? acquisitionType = null,
            bool? unlocked = null)
        {
            return Plugin.CardDisplayDataCollection.AllCards
                .Where(card =>
                    (category == null || card.Category == category.Value) &&
                    (subcategory == null || card.Subcategory == subcategory) &&
                    (acquisitionType == null || (card.AcquisitionType & acquisitionType.Value) != 0) &&
                    (unlocked == null || card.Unlocked == unlocked.Value)
                ).ToList();
        }

        public static CardDisplayData GetCard(string cardUnlockName = null, string cardTitle = null)
        {
            if (string.IsNullOrEmpty(cardTitle) && string.IsNullOrEmpty(cardUnlockName))
            {
                Plugin.Log.LogWarning("GetCard called without cardTitle or cardUnlockName.");
                return null;
            }
            return Plugin.CardDisplayDataCollection.AllCards
                .FirstOrDefault(card =>
                    (cardUnlockName != null && card.UnlockName == cardUnlockName) ||
                    (cardTitle != null && card.Title == cardTitle));
        }

        public static void SyncCardUnlockedStatus()
        {
            SyncCardUnclocked.SyncCardUnlockedStatus();
        }
    }
}
