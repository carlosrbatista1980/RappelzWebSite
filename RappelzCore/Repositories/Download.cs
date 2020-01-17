using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using Microsoft.EntityFrameworkCore;
using RappelzCore.Repositories.Interfaces;

namespace RappelzCore.Repositories
{
    public class Download : IEntity<int>
    {
        public int Id { get; set; }

        /// <summary>
        /// Relationship with [Auth].Account
        /// </summary>
        public int? AccountId { get; set; }

        /// <summary>
        /// User's IpAdress
        /// </summary>
        public string Ip { get; set; }

        /// <summary>
        /// User's Country
        /// </summary>
        public string Country { get; set; }
        
        /// <summary>
        /// User's State
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// DateTime of rappelzclient download
        /// </summary>
        public DateTime DateDownload { get; set; }

        /// <summary>
        /// How many times rappelzclient has been download from a User
        /// </summary>
        public int DownloadCount { get; set; }

        /// <summary>
        /// Show if user has donated at least once
        /// </summary>
        public bool? HasDonated { get; set; }

        /// <summary>
        /// Show if user is logged
        /// </summary>
        public int? SessionId { get; set; }

        public string DownloadLink1 { get; set; }
        public string DownloadLink2 { get; set; }
        public string DownloadLink3 { get; set; }

        public Download()
        {
            DateDownload = DateTime.Now;
            DownloadCount = 0;
        }
    }
}
