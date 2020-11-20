using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BepInEx;

namespace CopycatQol
{
    [BepInPlugin(ModInfo.GUID, ModInfo.PluginName, ModInfo.Version)]
    public class Bootloader : BaseUnityPlugin
    {

    }

    public static class ModInfo
    {
        public const string GUID = "com.maplewheels.copycatqol";
        public const string PluginName = "Copycat Quality of Life";
        public const string Version = "0.0.1";
    }
}
