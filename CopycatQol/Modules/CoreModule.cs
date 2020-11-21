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
    internal class CoreModule : IModule
    {
        internal static GeneralConfig Config { get; private set; }
        internal static ManualLogSource Logger { get; private set; }
        
        private PlayerLoadoutModule _PlayerLoadoutModule;
        internal PlayerLoadoutModule PlayerLoadoutModule
        {
            get
            {
                if (_PlayerLoadoutModule == null)
                    _PlayerLoadoutModule = new PlayerLoadoutModule();
                return _PlayerLoadoutModule;
            }
        }
        public bool IsEnabled { get; private set; }

        public bool IsLoaded { get; private set; }

        public void DisableModule()
        {
            if (!IsEnabled || !IsLoaded)
                return;

            PlayerLoadoutModule.DisableModule();

            IsEnabled = false;
        }

        public void EnableModule()
        {
            if (IsEnabled || !IsLoaded)
                return;

            PlayerLoadoutModule.EnableModule();

            IsEnabled = true;
        }

        public void LoadModule(ConfigFile File, ManualLogSource Logger)
        {
            if (IsLoaded)
                UnloadModule();

            CoreModule.Logger = Logger;
            CoreModule.Config = File.BindModel<GeneralConfig>(Logger);

            PlayerLoadoutModule.LoadModule(File, Logger);

            IsLoaded = true;

            EnableModule();
        }

        public void UnloadModule()
        {
            if (!IsLoaded)
                return;

            if (IsEnabled)
                DisableModule();

            if(PlayerLoadoutModule != null)
            {
                PlayerLoadoutModule.UnloadModule();
            }

            IsLoaded = false;
        }
    }
}
