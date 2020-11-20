using BepInEx.Extensions.Configuration;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopycatQol.Configuration
{
    public class LoadoutConfig : IConfigBase
    {
        public ConfigData<bool> Enabled { get; set; } = new ConfigData<bool>()
        {
            DescriptionString = "Enable/Disable this module.",
            DefaultValue = true
        };

        public ConfigData<int> Loadout_Rifleman_AmmoBase { get; set; } = new ConfigData<int>()
        {
            DescriptionString = "The base amount of ammo given to the Rifleman",
            DefaultValue = 90
        };

        public ConfigData<int> Loadout_Rifleman_AmmoDivToAllPlayers { get; set; } = new ConfigData<int>()
        {
            DescriptionString = "The amount of ammo shared out to all of the players. Note: divided by all players but affects only Rifleman.",
            DefaultValue = 330
        };

        public ConfigData<int> Loadout_Rifleman_AmmoBase { get; set; } = new ConfigData<int>()
        {
            DescriptionString = "The base amount of ammo given to the Rifleman",
            DefaultValue = 90
        };

        public ConfigData<int> Loadout_Rifleman_AmmoDivToAllPlayers { get; set; } = new ConfigData<int>()
        {
            DescriptionString = "The amount of ammo shared out to all of the players. Note: divided by all players but affects only Rifleman.",
            DefaultValue = 330
        };
    }
}
