using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RappelzWebSite.Models
{
    public class DownloadViewModel
    {
        public int? AccountId { get; set; }
        public string Ip { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public DateTime DateDownload { get; set; }
        public int DownloadCount { get; set; }
        public bool? HasDonated { get; set; }
        public int? SessionId { get; set; }
        public string DownloadLink1 { get; set; }
        public string DownloadLink2 { get; set; }
        public string DownloadLink3 { get; set; }
    }
}
