using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MakePlaylist
{
    public class ExtPath
    {
        public const string INTERNAL_SD = "/mnt/internal_sd/";
        public const string EXTERNAL_SD = "/mnt/external_sd/";
        public const string EXTERNAL_SD2 = "/mnt/external_sd2/";

        public Storage id { get; set; }
        public string pathName { get; set; }
    }

    public enum Storage
    {
        Internal,
        External,
        External2,
        None
    }
}
