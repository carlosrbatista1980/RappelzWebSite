using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RappelzCore.Repositories;

namespace RappelzWebSite.Models
{
    public class LoginViewModel
    {
        public int account_id { get; set; } //[Auth].[Account].account_id
        public string account { get; set; } //[Auth].[Account].account
        public string password { get; set; } //[Auth].[Account].password
        public string email { get; set; } //[Auth].[Account].email
        public int block { get; set; } //[Auth].[Account].block
        public string IP_user { get; set; } //[Auth].[Account].IP_user
        public DateTime datePassword { get; set; }
        public int? GameCoin { get; set; }
        public DateTime? DateLastGameCoinBought { get; set; }
        public int SessionId { get; set; }
    }
}
