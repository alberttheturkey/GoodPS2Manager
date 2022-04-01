using DiscUtils.Iso9660;
using System;
using System.IO;
using System.Linq;

namespace GoodPS2Manager
{
    public interface IDiscImage
    {
        enum DiscType { None, DVD, CD }
        DiscType Type { get; }
        string Path { get; set; }

        string VolumeLabel { get; set; }
        long Size { get; set; }
        long Clusters { get; set; }
        long ClusterSize { get; set; }
        bool IsCDImage { get; }

        void ReadDisc();
        void WriteDisc();
    }

    public class DiscUtilsCDImage : DiscUtilsImage
    {
        public new IDiscImage.DiscType Type { get => IDiscImage.DiscType.CD; }
        public DiscUtilsCDImage(string path) : base(path)
        {

        }
    }

    public class DiscUtilsDVDImage : DiscUtilsImage
    {
        public new IDiscImage.DiscType Type { get => IDiscImage.DiscType.DVD; }
        public DiscUtilsDVDImage(string path) : base(path)
        {

        }
    }

    public class DiscUtilsImage : IDiscImage
    {

        readonly long CDClusterCount = 333000; // Unfortunately the only way to detect a CD ISO
        public string Path { get; set; }
        public IDiscImage.DiscType Type { get => IDiscImage.DiscType.None; }
        public string VolumeLabel { get; set; }

        public DiscContents Contents { get; set; } = new DiscContents();
        public long Size { get; set; }

        public long Clusters { get; set; }
        public long ClusterSize { get; set; }
        public bool IsCDImage { get => Clusters < CDClusterCount; }

        public DiscUtilsImage(string path)
        {
            Path = path;
            ReadDisc();
        }

        public void ReadDisc()
        {
            // open up our ISO before reading the files
            // Full file name   
            FileInfo discFile = new FileInfo(Path);

            if (discFile.Exists)
            {
                if(!GamesFolder.ImageExtensions.Any(x=>$".{x.Key}" == discFile.Extension))
                {
                    throw new ImageFileIncorrectExtensionException("Image file is not in correct format");
                }

                using FileStream isoStream = File.OpenRead(Path);
                CDReader disc = new CDReader(isoStream, true);
                VolumeLabel = disc.VolumeLabel;
                Size = isoStream.Length;
                Clusters = disc.TotalClusters;
                ClusterSize = disc.ClusterSize;

                if (disc.FileExists(DiscContents.SystemCNFFileName))
                {
                    using StreamReader reader = new StreamReader(disc.OpenFile(DiscContents.SystemCNFFileName, FileMode.Open));                    
                    Contents.SystemConfig = new SystemConfig(reader);
                }
            }
            else
            {
                throw new ImageFileDoesNotExistException("Image file doesn't exist");
            }
        }

        public void WriteDisc()
        {
            throw new NotImplementedException();
        }
    }

}
