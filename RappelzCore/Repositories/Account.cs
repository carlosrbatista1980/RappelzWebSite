using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RappelzCore.Repositories.Interfaces;

namespace RappelzCore.Repositories
{
    public class Account : Entity
    {
        public int account_id { get; set; } //[Auth].[Account].account_id
        public string account { get; set; } //[Auth].[Account].account
        public string password { get; set; } //[Auth].[Account].password
        public string email { get; set; } //[Auth].[Account].email
        public string password2 { get; set; } //[Auth].[Account].password2
        public string phone { get; set; } //[Auth].[Account].phone
        public int block { get; set; } //[Auth].[Account].block
        public string IP_user { get; set; } //[Auth].[Account].IP_user
        public int Admin { get; set; } //[Auth].[Account].Admin
        public int point { get; set; } //[Auth].[Account].point
        public DateTime datePassword { get; set; } 
        public int? last_login_server_idx { get; set; } //[Auth].[Account].last_login_server_idx
        public int? GameCoin { get; set; }
        public DateTime? DateLastGameCoinBought { get; set; }

        public Account()
        {
            password2 = !string.IsNullOrEmpty(password) ? password : "0";
            phone = "55-21-9999-9999";
            block = 0;
            IP_user = "127.0.0.1";
            Admin = 0;
            point = 0;
            last_login_server_idx = 0;
        }
    }
}
