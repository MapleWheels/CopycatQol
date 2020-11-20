using BepInEx.Configuration;
using BepInEx.Logging;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopycatQol.Modules
{
    internal class CoreModule : IModule
    {
        public bool IsEnabled { get; private set; }

        public bool IsLoaded { get; private set; }

        public void DisableModule()
        {
            throw new NotImplementedException();
        }

        public void EnableModule()
        {
            throw new NotImplementedException();
        }

        public void LoadModule(ConfigFile File, ManualLogSource Logger)
        {
            throw new NotImplementedException();
        }

        public void UnloadModule()
        {
            throw new NotImplementedException();
        }
    }
}
