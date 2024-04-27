﻿using HarmonyLib;
using Tests.HarmonyMocks;

namespace Tests;

public class HarmonyTestBase
{
	[SetUp]
	public virtual void Setup()
	{
		var harmony = new Harmony("fse.tests");

		HarmonyFarmer.Setup(harmony);
		HarmonyGame.Setup(harmony);
		HarmonyFarmerCollection.Setup(harmony);
		HarmonyFarmerTeam.Setup(harmony);
		HarmonyFarm.Setup(harmony);
		HarmonyObject.Setup(harmony);
		HarmonyModMessageReceivedEventArgs.Setup(harmony);
		HarmonySpriteFont.Setup(harmony);
		HarmonyUtility.Setup(harmony);
		HarmonySpriteBatch.Setup(harmony);
		HarmonyGameMenu.Setup(harmony);
		HarmonyOptions.Setup(harmony);
	}
}