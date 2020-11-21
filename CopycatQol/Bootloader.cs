using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BepInEx;

using CopycatQol.Modules;

namespace CopycatQol
{
    [BepInDependency(BepInEx.Extensions.LibraryInfo.BepInDependencyID)]
    [BepInPlugin(ModInfo.GUID, ModInfo.PluginName, ModInfo.Version)]
    public class Bootloader : BaseUnityPlugin
    {
        private CoreModule _CoreModule;
        internal CoreModule CoreModule 
        { 
            get
            {
                if (_CoreModule == null)
                    _CoreModule = new CoreModule();
                return _CoreModule;
            } 
        }

        void Awake()
        {
            CoreModule.LoadModule(Config, Logger);
        }
    }

    public static class ModInfo
    {
        public const string GUID = "com.maplewheels.copycatqol";
        public const string PluginName = "Copycat Quality of Life";
        public const string Version = "0.0.1";
    }
}
