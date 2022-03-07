using System.Configuration;
using System.IO;

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
            return Path.IsPathRooted(DefaultOPLPath);
        }
    }
}
