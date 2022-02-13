﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

namespace GoodPS2Manager
{
    public class OPLFolderStructure
    {

        public string RootFolder { get; set; }
        public OPLFolder APPS { get; set; }
        public OPLFolder ART { get; set; }
        public GamesFolder CD { get; set; }
        public OPLFolder CFG { get; set; }
        public OPLFolder CHT { get; set; }
        public GamesFolder DVD { get; set; }
        public OPLFolder POPS { get; set; }
        public OPLFolder VMC { get; set; }
        public bool MissingFolders { 
            get 
            {
                return !APPS.FolderExists || !ART.FolderExists || !CD.FolderExists // If none of the folders exists then 
                    || !CFG.FolderExists || !CHT.FolderExists || !DVD.FolderExists
                    || !DVD.FolderExists || !POPS.FolderExists || !VMC.FolderExists;
            } 
        }

        public bool FolderExists { 
            get
            {
                return Directory.Exists(RootFolder);
            } 
        }
        
        public OPLFolderStructure(string path, bool createFolder = false)
        {            
            RootFolder = path;

            if (!Directory.Exists(RootFolder))
            {
                if (createFolder)
                {
                    Directory.CreateDirectory(RootFolder);
                }
                else
                {
                    throw new Exception($"OPL Directory \"{RootFolder}\" doesn't exist");
                }
            }

            Refresh();

            if (createFolder)
            {
                CreateMissingOPLFolders();
            }
        }

        public void Refresh()
        {
            APPS = new OPLFolder($"{RootFolder}\\APPS");
            ART = new OPLFolder($"{RootFolder}\\ART");
            CD = new GamesFolder($"{RootFolder}\\CD", GamesFolder.GameFolderType.CD);
            CFG = new OPLFolder($"{RootFolder}\\CFG");
            CHT = new OPLFolder($"{RootFolder}\\CHT");
            DVD = new GamesFolder($"{RootFolder}\\DVD", GamesFolder.GameFolderType.DVD);
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

        public bool CopyGameToFolder(string path, IProgress<int> progress, CancellationToken cancellationToken)
        {
            // Cancel the operation if signal is sent
            try
            {
                cancellationToken.ThrowIfCancellationRequested();
            }
            catch
            {
                throw;
            }

            bool result = false;

            if (File.Exists(path)) {
                // We check to see if it's a CD before we move anything
                File.Copy(path, $"{(new DiscUtilsImage(path).IsCDImage ? CD.Path : DVD.Path)}\\{Path.GetFileName(path)}");
                result = true;
            }
            progress.Report(1);

            return result;
        }

        internal void CreateMissingOPLFolders()
        {
            // Should probably implement these folders as part of a dictionary with an enum instead
            // For now that's over engineering it a bit so we'll just do this stuff manually for now
            APPS.CreateFolder();
            ART.CreateFolder();
            CD.CreateFolder();
            CFG.CreateFolder();
            CHT.CreateFolder();
            DVD.CreateFolder();
            POPS.CreateFolder();
            VMC.CreateFolder();
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

        public void CreateFolder()
        {
            if (!Directory.Exists(Path))
            {
                Directory.CreateDirectory(Path);
            }
        }
    }

    public class GamesFolder : OPLFolder
    {
        // Add DVD extension types here, make sure extension types are LOWER CASE
        public static List<string> ImageExtensions = new List<string> { "iso" };
        public List<Game> GamesList { get; set; } = new List<Game>();
        public enum GameFolderType { None, DVD, CD }
        public GameFolderType FolderType;

        public GamesFolder(string path, GameFolderType folderType) : base(path)
        {
            FolderType = folderType;
            PopulateGamesList();
        }

        public void PopulateGamesList()
        {
            if (Directory.Exists(Path))
            {
                // Get all our files in the DVD directory that match the accepted extensions
                // Uses EnumerateFiles for performance benefits
                var gameFiles = Directory.EnumerateFiles(Path, "*.*", SearchOption.AllDirectories)
                    .Where(s =>
                        ImageExtensions.Contains(
                            System.IO.Path.GetExtension(s).TrimStart('.').ToLowerInvariant()
                            )
                        );

                // Set our game type based on folder, right now Dual Layer DVD's can't be detected
                // When it's possible to test dual layers this will need to be moved into the game
                // ISO reading logic
                var gameType = Game.GameType.None;

                switch (FolderType)
                {
                    case GameFolderType.CD:
                        gameType = Game.GameType.CD;
                        break;
                    case GameFolderType.DVD:
                        gameType = Game.GameType.DVD5;
                        break;
                }

                foreach (var gameFilePath in gameFiles)
                {
                    GamesList.Add(new Game(gameFilePath, gameType));
                }
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

        public Game(string path, GameType type)
        {
            // Some items can be inferred without the image
            Name = Path.GetFileNameWithoutExtension(path);
            Type = type;

            GetGameFromPath(path);
        }

        private void GetGameFromPath(string path)
        {
            // Create a DVD image object to get the game information from
            var image = new DiscUtilsImage(path)
            {
                Path = path
            };
            image.ReadDisc();
            
            // Load image info into game object
            ID = image.Contents.SystemConfig.BOOT2;
            Region = image.Contents.SystemConfig.VMODE;
            VolumeName = image.VolumeLabel;
            Size = image.Size;
        }

    }
}
