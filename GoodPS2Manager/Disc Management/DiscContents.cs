using System;
using System.IO;
using System.Text.RegularExpressions;

namespace GoodPS2Manager
{
    public class DiscContents
    {
        public const string SystemCNFFileName = "SYSTEM.CNF";

        public SystemConfig SystemConfig { get; set; }
        public DiscContents()
        {

        }
    }

    public class SystemConfig
    {
        public const string BootParameter = "BOOT2";
        public const string VersionParameter = "VER";
        public const string VideoModeParameter = "VMODE";
        public enum VideoMode { PAL, NTSC }
        public VideoMode VMODE { get; set; }
        public string BOOT2 { get; set; }
        public string VER { get; set; }

        public SystemConfig()
        {

        }

        public SystemConfig(StreamReader reader)
        {
            ParseConfigStrings(reader);
        }

        private void ParseConfigStrings(StreamReader reader)
        {
            var firstLine = reader.ReadLine();
            var secondLine = reader.ReadLine();
            var thirdLine = reader.ReadLine();

            if(firstLine == null || secondLine == null || thirdLine == null)
            {
                throw new Exception("Invalid Configuration String in Image");
            }

            if (firstLine.StartsWith(BootParameter))
            {
                // We first remove all spaces with \s+ and then we use \w{4}_\d{3}.\d{2} to identify the 
                // ID from the boot2 parameter, this matches 4 letters, then and _ then 3 digits then a .
                // then 2 digits, this should accurately catch the ID unless there is some strange ones
                // floating around out there
                
                BOOT2 = Regex.Match(Regex.Replace(firstLine, @"\s+", ""), @"\w{4}_\d{3}.\d{2}").Value;
            }

            if (secondLine.StartsWith(VersionParameter))
            {
                VER = secondLine.Trim();
            }

            if (thirdLine.StartsWith(VideoModeParameter))
            {
                VMODE = thirdLine.Trim().EndsWith(VideoMode.NTSC.ToString()) ? VideoMode.NTSC : VideoMode.PAL;
            }
        }
    }
}
