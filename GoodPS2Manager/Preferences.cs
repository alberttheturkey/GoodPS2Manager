using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodPS2Manager
{
    [SettingsSerializeAs(SettingsSerializeAs.Xml)]
    public class Preferences
    {
        public string DefaultOPLPath { get; set; } = "d:\\OPL";
        public bool LoadOPLFolderOnStartup { get; set; } = false;
        public bool CheckOPLFolderOnLoad { get; set; } = true;

        public Preferences()
        {

        }

        public bool ValidatePreferences()
        {
            bool preferencesValid = false;
            preferencesValid = Path.IsPathRooted(DefaultOPLPath);
            return preferencesValid;
        }
    }
}
