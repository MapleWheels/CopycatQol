using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CopycatQol.Utils
{
    internal static class ConfigTextMapper
    {
        internal static int StringToWeaponId(string weaponName)
        {
            foreach(Info.ItemIds itemId in Enum.GetValues(typeof(Info.ItemIds)))
            {
                if (Enum.GetName(typeof(Info.ItemIds), (int)itemId) == weaponName)
                    return (int)itemId;
            }

            return (int)Info.ItemIds.Null;
        }

        internal static string WeaponIdToString(Info.ItemIds itemId) => Enum.GetName(typeof(Info.ItemIds), (int)itemId);
    }
}
