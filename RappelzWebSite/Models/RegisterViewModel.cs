using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RappelzWebSite.Models
{
    public class RegisterViewModel
    {
        public string account { get; set; } //[Auth].[Account].account
        public string password { get; set; } //[Auth].[Account].password
        public string email { get; set; } //[Auth].[Account].email
        public string IP_user { get; set; } //[Auth].[Account].IP_user
        public DateTime dateRegisterCreated { get; set; }
    }
}
