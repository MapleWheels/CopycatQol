using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BepInEx.Extensions.Configuration;

namespace CopycatQol.Configuration
{
    public class RiflemanLoadoutConfig : ConfigDataModel
    {
        public override void SetDefaults() => SectionName = "Rifleman_Loadout";

        //Slot0
        public ConfigData<Info.ItemIds> InvSlot0Weapon { get; set; } = new ConfigData<Info.ItemIds>()
        {
            DescriptionString = "The item in the first slot of the inventory.",
            DefaultValue = Info.ItemIds.RiflemanRifle
        };

        public ConfigData<int> InvSlot0AmmoBase { get; set; } = new ConfigData<int>()
        {
            DescriptionString = "The ammunition/supply count for the first slot",
            DefaultValue = 90
        };

        public ConfigData<int> InvSlot0AmmoDiv { get; set; } = new ConfigData<int>()
        {
            DescriptionString = "The extra ammunition given to the first slot divided by the player count",
            DefaultValue = 330
        };

        public ConfigData<int> InvSlot0AmmoMul { get; set; } = new ConfigData<int>()
        {
            DescriptionString = "The extra ammunition given to the first slot for each player",
            DefaultValue = 0
        };

        //Slot1
        public ConfigData<Info.ItemIds> InvSlot1Weapon { get; set; } = new ConfigData<Info.ItemIds>()
        {
            DescriptionString = "The item in the second slot of the inventory.",
            DefaultValue = Info.ItemIds.ReconPistol
        };

        public ConfigData<int> InvSlot1AmmoBase { get; set; } = new ConfigData<int>()
        {
            DescriptionString = "The ammunition/supply count for the second slot",
            DefaultValue = 60
        };

        public ConfigData<int> InvSlot1AmmoDiv { get; set; } = new ConfigData<int>()
        {
            DescriptionString = "The extra ammunition given to the second slot divided by the player count",
            DefaultValue = 120
        };

        public ConfigData<int> InvSlot1AmmoMul { get; set; } = new ConfigData<int>()
        {
            DescriptionString = "The extra ammunition given to the second slot for each player",
            DefaultValue = 0
        };

        //Slot2
        public ConfigData<Info.ItemIds> InvSlot2Weapon { get; set; } = new ConfigData<Info.ItemIds>()
        {
            DescriptionString = "The item in the third slot of the inventory.",
            DefaultValue = Info.ItemIds.MedicMorphine
        };

        public ConfigData<int> InvSlot2AmmoBase { get; set; } = new ConfigData<int>()
        {
            DescriptionString = "The ammunition/supply count for the third slot",
            DefaultValue = 1
        };

        public ConfigData<int> InvSlot2AmmoDiv { get; set; } = new ConfigData<int>()
        {
            DescriptionString = "The extra ammunition given to the third slot divided by the player count",
            DefaultValue = 0
        };
        public ConfigData<int> InvSlot2AmmoMul { get; set; } = new ConfigData<int>()
        {
            DescriptionString = "The extra ammunition given to the third slot for each player",
            DefaultValue = 0
        };

        //Slot3
        public ConfigData<Info.ItemIds> InvSlot3Weapon { get; set; } = new ConfigData<Info.ItemIds>()
        {
            DescriptionString = "The item in the fourth slot of the inventory.",
            DefaultValue = Info.ItemIds.Null
        };

        public ConfigData<int> InvSlot3AmmoBase { get; set; } = new ConfigData<int>()
        {
            DescriptionString = "The ammunition/supply count for the fourth slot",
            DefaultValue = 0
        };

        public ConfigData<int> InvSlot3AmmoDiv { get; set; } = new ConfigData<int>()
        {
            DescriptionString = "The extra ammunition given to the forth slot divided by the player count",
            DefaultValue = 0
        };
        public ConfigData<int> InvSlot3AmmoMul { get; set; } = new ConfigData<int>()
        {
            DescriptionString = "The extra ammunition given to the fourth slot for each player",
            DefaultValue = 0
        };

        //Slot4
        public ConfigData<Info.ItemIds> InvSlot4Weapon { get; set; } = new ConfigData<Info.ItemIds>()
        {
            DescriptionString = "The item in the fifth slot of the inventory.",
            DefaultValue = Info.ItemIds.Null
        };

        public ConfigData<int> InvSlot4AmmoBase { get; set; } = new ConfigData<int>()
        {
            DescriptionString = "The ammunition/supply count for the fifth slot",
            DefaultValue = 0
        };

        public ConfigData<int> InvSlot4AmmoDiv { get; set; } = new ConfigData<int>()
        {
            DescriptionString = "The extra ammunition given to the fifth slot divided by the player count",
            DefaultValue = 0
        };
        public ConfigData<int> InvSlot4AmmoMul { get; set; } = new ConfigData<int>()
        {
            DescriptionString = "The extra ammunition given to the fifth slot for each player",
            DefaultValue = 0
        };
    }
}
