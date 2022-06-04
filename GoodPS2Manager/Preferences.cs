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

        public Sidebar Sidebar { get; set; } = new Sidebar();

        public Preferences()
        {

        }

        public bool ValidatePreferences()
        {
            return Path.IsPathRooted(DefaultOPLPath);
        }
    }

    public class Sidebar { 
        public enum SidebarLocation { Left, Right };
        public SidebarLocation Location { get; set; } = SidebarLocation.Left;

        public bool Hidden { get; set; } = false;
    }

}
