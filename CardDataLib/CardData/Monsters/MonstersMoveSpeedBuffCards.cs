﻿using System.Collections.Generic;
using CardsShared;

namespace CardDataLib.CardData.Monsters
{
    public static class MonstersMoveSpeedBuffCards
    {
        internal static void Register()
        {
            Plugin.CardDisplayDataCollection.AllCards.AddRange(new List<CardDisplayData>
            {
                new CardDisplayData
                {
                    Title = "Speed I",
                    Description = "Monsters gain 0.05 movespeed",
                    SpriteName = "SinglePath",
                    UnlockName = "MonsterSpeed1",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterSpeed2" },
                    Unlocked = true,
                    Category = Category.Monster,
                    Subcategory = Subcategory.MonsterMoveSpeedBuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                },
                new CardDisplayData
                {
                    Title = "Speed II",
                    Description = "Monsters gain 0.05 movespeed",
                    SpriteName = "SinglePath",
                    UnlockName = "MonsterSpeed2",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterSpeed3" },
                    Unlocked = true,
                    Category = Category.Monster,
                    Subcategory = Subcategory.MonsterMoveSpeedBuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                },
                new CardDisplayData
                {
                    Title = "Speed III",
                    Description = "Monsters gain 0.1 movespeed",
                    SpriteName = "SinglePath",
                    UnlockName = "MonsterSpeed3",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterSpeed4" },
                    Unlocked = true,
                    Category = Category.Monster,
                    Subcategory = Subcategory.MonsterMoveSpeedBuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                },
                new CardDisplayData
                {
                    Title = "Speed IV",
                    Description = "Monsters gain 0.1 movespeed",
                    SpriteName = "SinglePath",
                    UnlockName = "MonsterSpeed4",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterSpeed5" },
                    Unlocked = true,
                    Category = Category.Monster,
                    Subcategory = Subcategory.MonsterMoveSpeedBuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                },
                new CardDisplayData
                {
                    Title = "Speed V",
                    Description = "Monsters gain 0.15 movespeed",
                    SpriteName = "SinglePath",
                    UnlockName = "MonsterSpeed5",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterSpeed6" },
                    Unlocked = true,
                    Category = Category.Monster,
                    Subcategory = Subcategory.MonsterMoveSpeedBuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                },
                new CardDisplayData
                {
                    Title = "Speed VI",
                    Description = "Monsters gain 0.15 movespeed",
                    SpriteName = "SinglePath",
                    UnlockName = "MonsterSpeed6",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterSpeed7" },
                    Unlocked = true,
                    Category = Category.Monster,
                    Subcategory = Subcategory.MonsterMoveSpeedBuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                },
                new CardDisplayData
                {
                    Title = "Speed VII",
                    Description = "Monsters gain 0.2 movespeed",
                    SpriteName = "SinglePath",
                    UnlockName = "MonsterSpeed7",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterSpeed8" },
                    Unlocked = true,
                    Category = Category.Monster,
                    Subcategory = Subcategory.MonsterMoveSpeedBuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                },
                new CardDisplayData
                {
                    Title = "Speed VIII",
                    Description = "Monsters gain 0.2 movespeed",
                    SpriteName = "SinglePath",
                    UnlockName = "MonsterSpeed8",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterSpeed9" },
                    Unlocked = true,
                    Category = Category.Monster,
                    Subcategory = Subcategory.MonsterMoveSpeedBuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                },
                new CardDisplayData
                {
                    Title = "Speed IX",
                    Description = "Monsters gain 0.25 movespeed",
                    SpriteName = "SinglePath",
                    UnlockName = "MonsterSpeed9",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterSpeed10" },
                    Unlocked = true,
                    Category = Category.Monster,
                    Subcategory = Subcategory.MonsterMoveSpeedBuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                },
                new CardDisplayData
                {
                    Title = "Speed X",
                    Description = "Monsters gain 0.25 movespeed",
                    SpriteName = "SinglePath",
                    UnlockName = "MonsterSpeed10",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterSpeed11" },
                    Unlocked = true,
                    Category = Category.Monster,
                    Subcategory = Subcategory.MonsterMoveSpeedBuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                },
                new CardDisplayData
                {
                    Title = "Speed XI",
                    Description = "Monsters gain 0.5 movespeed",
                    SpriteName = "SinglePath",
                    UnlockName = "MonsterSpeed11",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterSpeed12" },
                    Unlocked = true,
                    Category = Category.Monster,
                    Subcategory = Subcategory.MonsterMoveSpeedBuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                },
                new CardDisplayData
                {
                    Title = "Speed XII",
                    Description = "Monsters gain 0.5 movespeed",
                    SpriteName = "SinglePath",
                    UnlockName = "MonsterSpeed12",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterSpeed13" },
                    Unlocked = true,
                    Category = Category.Monster,
                    Subcategory = Subcategory.MonsterMoveSpeedBuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                },
                new CardDisplayData
                {
                    Title = "Speed XIII",
                    Description = "Monsters gain 0.75 movespeed",
                    SpriteName = "SinglePath",
                    UnlockName = "MonsterSpeed13",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterSpeed14" },
                    Unlocked = true,
                    Category = Category.Monster,
                    Subcategory = Subcategory.MonsterMoveSpeedBuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                },
                new CardDisplayData
                {
                    Title = "Speed XIV",
                    Description = "Monsters gain 0.75 movespeed",
                    SpriteName = "SinglePath",
                    UnlockName = "MonsterSpeed14",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { "MonsterSpeed15" },
                    Unlocked = true,
                    Category = Category.Monster,
                    Subcategory = Subcategory.MonsterMoveSpeedBuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                },
                new CardDisplayData
                {
                    Title = "Speed XV",
                    Description = "Monsters gain 1.00 movespeed",
                    SpriteName = "SinglePath",
                    UnlockName = "MonsterSpeed15",
                    UnlockedByDefault = true,
                    Unlocks = new List<string> { },
                    Unlocked = true,
                    Category = Category.Monster,
                    Subcategory = Subcategory.MonsterMoveSpeedBuff,
                    AcquisitionType = AcquisitionType.AlwaysInRun,
                }
            });
        }
    }
}
