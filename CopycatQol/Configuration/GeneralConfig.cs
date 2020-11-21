using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BepInEx.Extensions.Configuration;

namespace CopycatQol.Configuration
{
    public class GeneralConfig : ConfigDataModel, IConfigBase
    {

        public override void SetDefaults() => SectionName = "General";

        public ConfigData<bool> Enabled { get; set; } = new ConfigData<bool>()
        {
            DescriptionString = "Enable/Disable the mod",
            DefaultValue = true
        };
    }
}
