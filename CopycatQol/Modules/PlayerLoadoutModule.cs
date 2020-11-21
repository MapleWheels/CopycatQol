using BepInEx.Configuration;
using BepInEx.Logging;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CopycatQol.Configuration;
using BepInEx.Extensions.Configuration;

namespace CopycatQol.Modules
{
    internal class PlayerLoadoutModule : IModule
    {
        static ReconLoadoutConfig ReconConfig;
        static RiflemanLoadoutConfig RiflemanConfig;
        static MedicLoadoutConfig MedicConfig;
        static CommandoLoadoutConfig CommandoConfig;

		static ManualLogSource Logger;

		public bool IsEnabled { get; private set; } = false;
		public bool IsLoaded { get; private set; } = false;

        public void DisableModule()
        {
			if (!IsEnabled)
				return;

			LoadoutPatch.Unpatch();

			Logger.LogInfo("PlayerLoadoutModule Disabled.");
			IsEnabled = false;
		}

        public void EnableModule()
        {
			if (!IsLoaded || IsEnabled)
				return;

			LoadoutPatch.Patch();

			Logger.LogInfo("PlayerLoadoutModule Enabled.");
			IsEnabled = true;
        }

        public void LoadModule(ConfigFile File, ManualLogSource Logger)
        {
			if (IsLoaded)
				UnloadModule();

			Logger.LogWarning("00");

            PlayerLoadoutModule.Logger = Logger;

			Logger.LogWarning("01");

			PlayerLoadoutModule.ReconConfig = File.BindModel<ReconLoadoutConfig>(Logger);
            PlayerLoadoutModule.RiflemanConfig = File.BindModel<RiflemanLoadoutConfig>(Logger);
            PlayerLoadoutModule.MedicConfig = File.BindModel<MedicLoadoutConfig>(Logger);
            PlayerLoadoutModule.CommandoConfig = File.BindModel<CommandoLoadoutConfig>(Logger);

			Logger.LogWarning("02");

			for(int i=0; i<5; i++)
            {
				LoadoutPatch.ReconLoadout[i] = new InvItemLoadout();
				LoadoutPatch.RiflemanLoadout[i] = new InvItemLoadout();
				LoadoutPatch.MedicLoadout[i] = new InvItemLoadout();
				LoadoutPatch.CommandoLoadout[i] = new InvItemLoadout();
			}

			//----Recon Config----//
			//Slot0
			LoadoutPatch.ReconLoadout[0].ItemId = ReconConfig.InvSlot0Weapon;
			LoadoutPatch.ReconLoadout[0].AmmoBase = ReconConfig.InvSlot0AmmoBase;
			LoadoutPatch.ReconLoadout[0].AmmoDiv = ReconConfig.InvSlot0AmmoDiv;
			LoadoutPatch.ReconLoadout[0].AmmoMul = ReconConfig.InvSlot0AmmoMul;
			//Slot1
			LoadoutPatch.ReconLoadout[1].ItemId = ReconConfig.InvSlot1Weapon;
			LoadoutPatch.ReconLoadout[1].AmmoBase = ReconConfig.InvSlot1AmmoBase;
			LoadoutPatch.ReconLoadout[1].AmmoDiv = ReconConfig.InvSlot1AmmoDiv;
			LoadoutPatch.ReconLoadout[1].AmmoMul = ReconConfig.InvSlot1AmmoMul;
			//Slot2
			LoadoutPatch.ReconLoadout[2].ItemId = ReconConfig.InvSlot2Weapon;
			LoadoutPatch.ReconLoadout[2].AmmoBase = ReconConfig.InvSlot2AmmoBase;
			LoadoutPatch.ReconLoadout[2].AmmoDiv = ReconConfig.InvSlot2AmmoDiv;
			LoadoutPatch.ReconLoadout[2].AmmoMul = ReconConfig.InvSlot2AmmoMul;
			//Slot3
			LoadoutPatch.ReconLoadout[3].ItemId = ReconConfig.InvSlot3Weapon;
			LoadoutPatch.ReconLoadout[3].AmmoBase = ReconConfig.InvSlot3AmmoBase;
			LoadoutPatch.ReconLoadout[3].AmmoDiv = ReconConfig.InvSlot3AmmoDiv;
			LoadoutPatch.ReconLoadout[3].AmmoMul = ReconConfig.InvSlot3AmmoMul;
			//Slot4
			LoadoutPatch.ReconLoadout[4].ItemId = ReconConfig.InvSlot4Weapon;
			LoadoutPatch.ReconLoadout[4].AmmoBase = ReconConfig.InvSlot4AmmoBase;
			LoadoutPatch.ReconLoadout[4].AmmoDiv = ReconConfig.InvSlot4AmmoDiv;
			LoadoutPatch.ReconLoadout[4].AmmoMul = ReconConfig.InvSlot4AmmoMul;

			//----Rifleman Config----//
			//Slot0
			LoadoutPatch.RiflemanLoadout[0].ItemId = RiflemanConfig.InvSlot0Weapon;
			LoadoutPatch.RiflemanLoadout[0].AmmoBase = RiflemanConfig.InvSlot0AmmoBase;
			LoadoutPatch.RiflemanLoadout[0].AmmoDiv = RiflemanConfig.InvSlot0AmmoDiv;
			LoadoutPatch.RiflemanLoadout[0].AmmoMul = RiflemanConfig.InvSlot0AmmoMul;
			//Slot1
			LoadoutPatch.RiflemanLoadout[1].ItemId = RiflemanConfig.InvSlot1Weapon;
			LoadoutPatch.RiflemanLoadout[1].AmmoBase = RiflemanConfig.InvSlot1AmmoBase;
			LoadoutPatch.RiflemanLoadout[1].AmmoDiv = RiflemanConfig.InvSlot1AmmoDiv;
			LoadoutPatch.RiflemanLoadout[1].AmmoMul = RiflemanConfig.InvSlot1AmmoMul;
			//Slot2
			LoadoutPatch.RiflemanLoadout[2].ItemId = RiflemanConfig.InvSlot2Weapon;
			LoadoutPatch.RiflemanLoadout[2].AmmoBase = RiflemanConfig.InvSlot2AmmoBase;
			LoadoutPatch.RiflemanLoadout[2].AmmoDiv = RiflemanConfig.InvSlot2AmmoDiv;
			LoadoutPatch.RiflemanLoadout[2].AmmoMul = RiflemanConfig.InvSlot2AmmoMul;
			//Slot3
			LoadoutPatch.RiflemanLoadout[3].ItemId = RiflemanConfig.InvSlot3Weapon;
			LoadoutPatch.RiflemanLoadout[3].AmmoBase = RiflemanConfig.InvSlot3AmmoBase;
			LoadoutPatch.RiflemanLoadout[3].AmmoDiv = RiflemanConfig.InvSlot3AmmoDiv;
			LoadoutPatch.RiflemanLoadout[3].AmmoMul = RiflemanConfig.InvSlot3AmmoMul;
			//Slot4
			LoadoutPatch.RiflemanLoadout[4].ItemId = RiflemanConfig.InvSlot4Weapon;
			LoadoutPatch.RiflemanLoadout[4].AmmoBase = RiflemanConfig.InvSlot4AmmoBase;
			LoadoutPatch.RiflemanLoadout[4].AmmoDiv = RiflemanConfig.InvSlot4AmmoDiv;
			LoadoutPatch.RiflemanLoadout[4].AmmoMul = RiflemanConfig.InvSlot4AmmoMul;

			//----Medic Config----//
			//Slot0
			LoadoutPatch.MedicLoadout[0].ItemId = MedicConfig.InvSlot0Weapon;
			LoadoutPatch.MedicLoadout[0].AmmoBase = MedicConfig.InvSlot0AmmoBase;
			LoadoutPatch.MedicLoadout[0].AmmoDiv = MedicConfig.InvSlot0AmmoDiv;
			LoadoutPatch.MedicLoadout[0].AmmoMul = MedicConfig.InvSlot0AmmoMul;
			//Slot1
			LoadoutPatch.MedicLoadout[1].ItemId = MedicConfig.InvSlot1Weapon;
			LoadoutPatch.MedicLoadout[1].AmmoBase = MedicConfig.InvSlot1AmmoBase;
			LoadoutPatch.MedicLoadout[1].AmmoDiv = MedicConfig.InvSlot1AmmoDiv;
			LoadoutPatch.MedicLoadout[1].AmmoMul = MedicConfig.InvSlot1AmmoMul;
			//Slot2
			LoadoutPatch.MedicLoadout[2].ItemId = MedicConfig.InvSlot2Weapon;
			LoadoutPatch.MedicLoadout[2].AmmoBase = MedicConfig.InvSlot2AmmoBase;
			LoadoutPatch.MedicLoadout[2].AmmoDiv = MedicConfig.InvSlot2AmmoDiv;
			LoadoutPatch.MedicLoadout[2].AmmoMul = MedicConfig.InvSlot2AmmoMul;
			//Slot3
			LoadoutPatch.MedicLoadout[3].ItemId = MedicConfig.InvSlot3Weapon;
			LoadoutPatch.MedicLoadout[3].AmmoBase = MedicConfig.InvSlot3AmmoBase;
			LoadoutPatch.MedicLoadout[3].AmmoDiv = MedicConfig.InvSlot3AmmoDiv;
			LoadoutPatch.MedicLoadout[3].AmmoMul = MedicConfig.InvSlot3AmmoMul;
			//Slot4
			LoadoutPatch.MedicLoadout[4].ItemId = MedicConfig.InvSlot4Weapon;
			LoadoutPatch.MedicLoadout[4].AmmoBase = MedicConfig.InvSlot4AmmoBase;
			LoadoutPatch.MedicLoadout[4].AmmoDiv = MedicConfig.InvSlot4AmmoDiv;
			LoadoutPatch.MedicLoadout[4].AmmoMul = MedicConfig.InvSlot4AmmoMul;

			//----Commando Config----//
			//Slot0
			LoadoutPatch.CommandoLoadout[0].ItemId = CommandoConfig.InvSlot0Weapon;
			LoadoutPatch.CommandoLoadout[0].AmmoBase = CommandoConfig.InvSlot0AmmoBase;
			LoadoutPatch.CommandoLoadout[0].AmmoDiv = CommandoConfig.InvSlot0AmmoDiv;
			LoadoutPatch.CommandoLoadout[0].AmmoMul = CommandoConfig.InvSlot0AmmoMul;
			//Slot1
			LoadoutPatch.CommandoLoadout[1].ItemId = CommandoConfig.InvSlot1Weapon;
			LoadoutPatch.CommandoLoadout[1].AmmoBase = CommandoConfig.InvSlot1AmmoBase;
			LoadoutPatch.CommandoLoadout[1].AmmoDiv = CommandoConfig.InvSlot1AmmoDiv;
			LoadoutPatch.CommandoLoadout[1].AmmoMul = CommandoConfig.InvSlot1AmmoMul;
			//Slot2
			LoadoutPatch.CommandoLoadout[2].ItemId = CommandoConfig.InvSlot2Weapon;
			LoadoutPatch.CommandoLoadout[2].AmmoBase = CommandoConfig.InvSlot2AmmoBase;
			LoadoutPatch.CommandoLoadout[2].AmmoDiv = CommandoConfig.InvSlot2AmmoDiv;
			LoadoutPatch.CommandoLoadout[2].AmmoMul = CommandoConfig.InvSlot2AmmoMul;
			//Slot3
			LoadoutPatch.CommandoLoadout[3].ItemId = CommandoConfig.InvSlot3Weapon;
			LoadoutPatch.CommandoLoadout[3].AmmoBase = CommandoConfig.InvSlot3AmmoBase;
			LoadoutPatch.CommandoLoadout[3].AmmoDiv = CommandoConfig.InvSlot3AmmoDiv;
			LoadoutPatch.CommandoLoadout[3].AmmoMul = CommandoConfig.InvSlot3AmmoMul;
			//Slot4
			LoadoutPatch.CommandoLoadout[4].ItemId = CommandoConfig.InvSlot4Weapon;
			LoadoutPatch.CommandoLoadout[4].AmmoBase = CommandoConfig.InvSlot4AmmoBase;
			LoadoutPatch.CommandoLoadout[4].AmmoDiv = CommandoConfig.InvSlot4AmmoDiv;
			LoadoutPatch.CommandoLoadout[4].AmmoMul = CommandoConfig.InvSlot4AmmoMul;

			Logger.LogWarning("03");

			IsLoaded = true;

			EnableModule();

			Logger.LogInfo("PlayerLoadoutModule Loaded.");
		}

        public void UnloadModule()
        {
			if (IsEnabled)
				DisableModule();
			if (!IsLoaded)
				return;
			
			Logger.LogInfo("PlayerLoadoutModule Unloaded.");
			IsLoaded = false;
        }

        static class LoadoutPatch
        {
            static bool LOADED = false;

            internal static InvItemLoadout[] ReconLoadout = new InvItemLoadout[5];
            internal static InvItemLoadout[] RiflemanLoadout = new InvItemLoadout[5];
            internal static InvItemLoadout[] MedicLoadout = new InvItemLoadout[5];
            internal static InvItemLoadout[] CommandoLoadout = new InvItemLoadout[5];

            internal static void Patch()
            {
                if (LOADED)
                    Unpatch();

				PlayerLoadoutModule.Logger.LogWarning("PlayerHumanScript::OnIntClassChange() patched in.");
				On.PlayerHumanScript.OnIntClassChange += PlayerHumanScript_OnIntClassChange_Hook;

				LOADED = true;
            }

            private static void PlayerHumanScript_OnIntClassChange_Hook(On.PlayerHumanScript.orig_OnIntClassChange orig, PlayerHumanScript self, PlayerHumanScript.PlayerClass change)
            {
                PlayerHumanScript_OnIntClassChange(self, change);
            }

            internal static void Unpatch()
            {
                if (!LOADED)
                    return;

				PlayerLoadoutModule.Logger.LogWarning("PlayerHumanScript::OnIntClassChange() patched OUT.");
				On.PlayerHumanScript.OnIntClassChange -= PlayerHumanScript_OnIntClassChange_Hook;

				LOADED = false;
            }

            public static void PlayerHumanScript_OnIntClassChange(PlayerHumanScript self, PlayerHumanScript.PlayerClass change)
            {
				if (!self.isServer)
				{
					self.NetworkcurrentClass = change;
				}
				if (change == PlayerHumanScript.PlayerClass.Commando)
				{
					self.navMapMark.SetActive(false);
				}
				if (!self.isLocalPlayer || change == PlayerHumanScript.PlayerClass.Undefined)
				{
					return;
				}
				int playerCount = UnityEngine.Object.FindObjectsOfType<LobbyPlayerScript>().Length;
				if (NetworkedGameManagerScript._instance.RandomSpawns)
				{
					self.wpnmgr.PresetWeaponAdd(16, 6, 1);
				}
				if (NetworkedGameManagerScript._instance.RandomItems)
				{
					int num2 = UnityEngine.Random.Range(1, 5);
					for (int i = 0; i < num2; i++)
					{
						self.wpnmgr.PresetWeaponAdd(UnityEngine.Random.Range(1, self.IdItemObjects.Length), i, UnityEngine.Random.Range(1, 5));
					}
				}
				else
				{
					switch (change)
					{
						case PlayerHumanScript.PlayerClass.Recon:
							//Slot0
							if (ReconLoadout[0].ItemId != Info.ItemIds.Null)
								self.wpnmgr.PresetWeaponAdd(
									(int)ReconLoadout[0].ItemId,
									0,
									ReconLoadout[0].AmmoBase + ReconLoadout[0].AmmoDiv / playerCount + ReconLoadout[0].AmmoMul * playerCount);
							//Slot1
							if (ReconLoadout[1].ItemId != Info.ItemIds.Null)
								self.wpnmgr.PresetWeaponAdd(
									(int)ReconLoadout[1].ItemId,
									1,
									ReconLoadout[1].AmmoBase + ReconLoadout[1].AmmoDiv / playerCount + ReconLoadout[1].AmmoMul * playerCount);
							//Slot2
							if (ReconLoadout[2].ItemId != Info.ItemIds.Null)
								self.wpnmgr.PresetWeaponAdd(
									(int)ReconLoadout[2].ItemId,
									2,
									ReconLoadout[2].AmmoBase + ReconLoadout[2].AmmoDiv / playerCount + ReconLoadout[2].AmmoMul * playerCount);
							//Slot3
							if (ReconLoadout[3].ItemId != Info.ItemIds.Null)
								self.wpnmgr.PresetWeaponAdd(
									(int)ReconLoadout[3].ItemId,
									3,
									ReconLoadout[3].AmmoBase + ReconLoadout[3].AmmoDiv / playerCount + ReconLoadout[3].AmmoMul * playerCount);
							//Slot4
							if (ReconLoadout[4].ItemId != Info.ItemIds.Null)
								self.wpnmgr.PresetWeaponAdd(
									(int)ReconLoadout[4].ItemId,
									4,
									ReconLoadout[4].AmmoBase + ReconLoadout[4].AmmoDiv / playerCount + ReconLoadout[4].AmmoMul * playerCount);
							break;
						case PlayerHumanScript.PlayerClass.Assault:
							//Slot0
							if (RiflemanLoadout[0].ItemId != Info.ItemIds.Null)
								self.wpnmgr.PresetWeaponAdd(
									(int)RiflemanLoadout[0].ItemId,
									0,
									RiflemanLoadout[0].AmmoBase + RiflemanLoadout[0].AmmoDiv / playerCount + RiflemanLoadout[0].AmmoMul * playerCount);
							//Slot1
							if (RiflemanLoadout[1].ItemId != Info.ItemIds.Null)
								self.wpnmgr.PresetWeaponAdd(
									(int)RiflemanLoadout[1].ItemId,
									1,
									RiflemanLoadout[1].AmmoBase + RiflemanLoadout[1].AmmoDiv / playerCount + RiflemanLoadout[1].AmmoMul * playerCount);
							//Slot2
							if (RiflemanLoadout[2].ItemId != Info.ItemIds.Null)
								self.wpnmgr.PresetWeaponAdd(
									(int)RiflemanLoadout[2].ItemId,
									2,
									RiflemanLoadout[2].AmmoBase + RiflemanLoadout[2].AmmoDiv / playerCount + RiflemanLoadout[2].AmmoMul * playerCount);
							//Slot3
							if (RiflemanLoadout[3].ItemId != Info.ItemIds.Null)
								self.wpnmgr.PresetWeaponAdd(
									(int)RiflemanLoadout[3].ItemId,
									3,
									RiflemanLoadout[3].AmmoBase + RiflemanLoadout[3].AmmoDiv / playerCount + RiflemanLoadout[3].AmmoMul * playerCount);
							//Slot4
							if (RiflemanLoadout[4].ItemId != Info.ItemIds.Null)
								self.wpnmgr.PresetWeaponAdd(
									(int)RiflemanLoadout[4].ItemId,
									4,
									RiflemanLoadout[4].AmmoBase + RiflemanLoadout[4].AmmoDiv / playerCount + RiflemanLoadout[4].AmmoMul * playerCount);
							break;
						case PlayerHumanScript.PlayerClass.Medic:
							//Slot0
							if (MedicLoadout[0].ItemId != Info.ItemIds.Null)
								self.wpnmgr.PresetWeaponAdd(
									(int)MedicLoadout[0].ItemId,
									0,
									MedicLoadout[0].AmmoBase + MedicLoadout[0].AmmoDiv / playerCount + MedicLoadout[0].AmmoMul * playerCount);
							//Slot1
							if (MedicLoadout[1].ItemId != Info.ItemIds.Null)
								self.wpnmgr.PresetWeaponAdd(
									(int)MedicLoadout[1].ItemId,
									1,
									MedicLoadout[1].AmmoBase + MedicLoadout[1].AmmoDiv / playerCount + MedicLoadout[1].AmmoMul * playerCount);
							//Slot2
							if (MedicLoadout[2].ItemId != Info.ItemIds.Null)
								self.wpnmgr.PresetWeaponAdd(
									(int)MedicLoadout[2].ItemId,
									2,
									MedicLoadout[2].AmmoBase + MedicLoadout[2].AmmoDiv / playerCount + MedicLoadout[2].AmmoMul * playerCount);
							//Slot3
							if (MedicLoadout[3].ItemId != Info.ItemIds.Null)
								self.wpnmgr.PresetWeaponAdd(
									(int)MedicLoadout[3].ItemId,
									3,
									MedicLoadout[3].AmmoBase + MedicLoadout[3].AmmoDiv / playerCount + MedicLoadout[3].AmmoMul * playerCount);
							//Slot4
							if (MedicLoadout[4].ItemId != Info.ItemIds.Null)
								self.wpnmgr.PresetWeaponAdd(
									(int)MedicLoadout[4].ItemId,
									4,
									MedicLoadout[4].AmmoBase + MedicLoadout[4].AmmoDiv / playerCount + MedicLoadout[4].AmmoMul * playerCount);
							break;
						case PlayerHumanScript.PlayerClass.Commando:
							//Slot0
							if (CommandoLoadout[0].ItemId != Info.ItemIds.Null)
								self.wpnmgr.PresetWeaponAdd(
									(int)CommandoLoadout[0].ItemId,
									0,
									CommandoLoadout[0].AmmoBase + CommandoLoadout[0].AmmoDiv / playerCount + CommandoLoadout[0].AmmoMul * playerCount);
							//Slot1
							if (CommandoLoadout[1].ItemId != Info.ItemIds.Null)
								self.wpnmgr.PresetWeaponAdd(
									(int)CommandoLoadout[1].ItemId,
									1,
									CommandoLoadout[1].AmmoBase + CommandoLoadout[1].AmmoDiv / playerCount + CommandoLoadout[1].AmmoMul * playerCount);
							//Slot2
							if (CommandoLoadout[2].ItemId != Info.ItemIds.Null)
								self.wpnmgr.PresetWeaponAdd(
									(int)CommandoLoadout[2].ItemId,
									2,
									CommandoLoadout[2].AmmoBase + CommandoLoadout[2].AmmoDiv / playerCount + CommandoLoadout[2].AmmoMul * playerCount);
							//Slot3
							if (CommandoLoadout[3].ItemId != Info.ItemIds.Null)
								self.wpnmgr.PresetWeaponAdd(
									(int)CommandoLoadout[3].ItemId,
									3,
									CommandoLoadout[3].AmmoBase + CommandoLoadout[3].AmmoDiv / playerCount + CommandoLoadout[3].AmmoMul * playerCount);
							//Slot4
							if (CommandoLoadout[4].ItemId != Info.ItemIds.Null)
								self.wpnmgr.PresetWeaponAdd(
									(int)CommandoLoadout[4].ItemId,
									4,
									CommandoLoadout[4].AmmoBase + CommandoLoadout[4].AmmoDiv / playerCount + CommandoLoadout[4].AmmoMul * playerCount);
							break;
					}
				}
				GameCanvasScript._instance.ShowClassInfo(change);
			}
        }

        internal class InvItemLoadout
        {
            internal Info.ItemIds ItemId = Info.ItemIds.Null;
            internal int AmmoBase;
            internal int AmmoDiv;
            internal int AmmoMul;
        }
    }
}
