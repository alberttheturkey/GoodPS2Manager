using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace GoodPS2Manager
{
    public class OPLFolderStructure
    {

        public string RootFolder { get; set; }
        public OPLFolder APPS { get; set; }
        public OPLFolder ART { get; set; }
        public OPLFolder CD { get; set; }
        public OPLFolder CFG { get; set; }
        public OPLFolder CHT { get; set; }
        public DVDFolder DVD { get; set; }
        public OPLFolder POPS { get; set; }
        public OPLFolder VMC { get; set; }

        public OPLFolderStructure(string path)
        {
            if (!Directory.Exists(path))
            {
                throw new Exception($"OPL Directory \"{path}\" doesn't exist");
            }
            RootFolder = path;
            Refresh();
        }

        public void Refresh()
        {
            APPS = new OPLFolder($"{RootFolder}\\APPS");
            ART = new OPLFolder($"{RootFolder}\\ART");
            CD = new OPLFolder($"{RootFolder}\\CD");
            CFG = new OPLFolder($"{RootFolder}\\CFG");
            CHT = new OPLFolder($"{RootFolder}\\CHT");
            DVD = new DVDFolder($"{RootFolder}\\DVD");
            POPS = new OPLFolder($"{RootFolder}\\POPS");
            VMC = new OPLFolder($"{RootFolder}\\VMC");
        }

        public override string ToString()
        {
            return $"Root Folder:{RootFolder}" +
                $"Apps:{APPS.Path} - {APPS.FolderExists}\n" +
                $"ART:{ART.Path} - {ART.FolderExists}\n" +
                $"CD:{CD.Path} - {CD.FolderExists}\n" +
                $"CFG:{CFG.Path} - {CFG.FolderExists}\n" +
                $"CHT:{CHT.Path} - {CHT.FolderExists}\n" +
                $"DVD:{DVD.Path} - {DVD.FolderExists}\n" +
                $"POPS:{POPS.Path} - {POPS.FolderExists}\n" +
                $"VMC:{VMC.Path} - {VMC.FolderExists}\n";
        }
    }

    public class OPLFolder
    {
        public string Path { get; set; }

        public bool FolderExists
        {
            get
            {
                return !string.IsNullOrEmpty(Path) && Directory.Exists(Path);
            }
        }

        public OPLFolder(string path)
        {
            Path = path;
        }
    }

    public class DVDFolder : OPLFolder
    {
        // Add DVD extension types here, make sure extension types are LOWER CASE
        public static List<string> DVDImageExtensions = new List<string> { "iso" };
        public List<Game> GamesList { get; set; } = new List<Game>();

        public DVDFolder(string path) : base(path)
        {
            PopulateGamesList();
        }

        public void PopulateGamesList()
        {
            // Get all our files in the DVD directory that match the accepted extensions
            // Uses EnumerateFiles for performance benefits
            var dvdFiles = Directory.EnumerateFiles(Path, "*.*", SearchOption.AllDirectories)
                .Where(s =>
                    DVDImageExtensions.Contains(
                        System.IO.Path.GetExtension(s).TrimStart('.').ToLowerInvariant()
                        )
                    );

            foreach (var dvdFilePath in dvdFiles)
            {
                GamesList.Add(new Game(dvdFilePath));
            }
        }
    }
    public class Game
    {
        public enum GameType { None, DVD5, DVD9, CD }
        public GameType Type { get; set; }
        public SystemConfig.VideoMode Region { get; set; }
        public string Name { get; set; }
        public string ID { get; set; }
        public string VolumeName { get; set; }
        public long Size { get; set; }

        public Game(string path)
        {
            GetGameFromPath(path);
        }

        private void GetGameFromPath(string path)
        {
            // Create a DVD image object to get the game information from
            var image = new DiscUtilsDVDImage(path)
            {
                Path = path
            };
            image.ReadDisc();
            
            // Load image info into game object
            ID = image.Contents.SystemConfig.BOOT2;
            Region = image.Contents.SystemConfig.VMODE;
            VolumeName = image.VolumeLabel;
            Size = image.Size;

            // Some items can be inferred without the image
            Name = Path.GetFileNameWithoutExtension(path);
            Type = GameType.DVD5;
        }

    }
}
