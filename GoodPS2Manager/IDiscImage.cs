using DiscUtils.Iso9660;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodPS2Manager
{
    public interface IDiscImage
    {
        enum DiscType { None, DVD, CD }
        DiscType Type { get; }
        string Path { get; set; }

        string VolumeLabel { get; set; }
        long Size { get; set; }

        void ReadDisc();
        void WriteDisc();
    }

    //public class DiscUtilsCDImage : IDiscImage
    //{
    //    public string Path { get; set; }
    //    public IDiscImage.DiscType Type { get => IDiscImage.DiscType.CD; }
    //    public string VolumeLabel { get; set; }

    //    public DiscUtilsCDImage(string path)
    //    {
    //        Path = path;
    //        ReadDisc();
    //    }

    //    public void ReadDisc()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void WriteDisc()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    public class DiscUtilsDVDImage : IDiscImage
    {
        public string Path { get; set; }
        public IDiscImage.DiscType Type { get => IDiscImage.DiscType.DVD; }
        public string VolumeLabel { get; set; }

        public DiscContents Contents { get; set; } = new DiscContents();
        public long Size { get; set; }

        public DiscUtilsDVDImage(string path)
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
                using FileStream isoStream = File.OpenRead(Path);
                CDReader disc = new CDReader(isoStream, true);
                VolumeLabel = disc.VolumeLabel;
                Size = isoStream.Length;

                if (disc.FileExists(DiscContents.SystemCNFFileName))
                {
                    using StreamReader reader = new StreamReader(disc.OpenFile(DiscContents.SystemCNFFileName, FileMode.Open));
                    Contents.SystemConfig = new SystemConfig(reader);
                }
            }
            else
            {
                throw new Exception("Image file doesn't exist");
            }
        }

        public void WriteDisc()
        {
            throw new NotImplementedException();
        }
    }

}
