using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopycatQol.Modules
{
    internal interface IModule
    {
        bool IsEnabled { get; }
        bool IsLoaded { get; }

        void LoadModule(BepInEx.Configuration.ConfigFile File, BepInEx.Logging.ManualLogSource Logger);
        void UnloadModule();
        void EnableModule();
        void DisableModule();
    }
}
