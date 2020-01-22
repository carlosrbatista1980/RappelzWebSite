using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using RappelzCore.Repositories;
using RappelzWebSite.Models.Interfaces;

namespace RappelzWebSite.Models
{
    public class LoginViewModel : ViewModelBase
    {
        public int account_id { get; set; } //[Auth].[Account].account_id
        public string account { get; set; } //[Auth].[Account].account
        public string password { get; set; } //[Auth].[Account].password
        public string email { get; set; } //[Auth].[Account].email
        public int block { get; set; } //[Auth].[Account].block
        public string IP_user { get; set; } //[Auth].[Account].IP_user
        public string confirmedpassword { get; set; }
        public DateTime datePassword { get; set; }
        public int? GameCoin { get; set; }
        public DateTime? DateLastGameCoinBought { get; set; }
        public int SessionId { get; set; }
        public DateTime dateRegisterCreated { get; set; }
        public bool _EventSuccess { get; set; }
        public string _EventMesssage { get; set; }

        //Check if ViewModel has changed
        //This implementation was a try to check if ViewModel has changed but, its not finished yet
        private int __EventGetter = DateTime.Now.Millisecond;
        public int ViewModelChanged
        {
            get
            {
                return __EventGetter;
            }
            set
            {
                SetProperty(ref __EventGetter, value);
            }
        }

        public LoginViewModel()
        {
        }
    }
}
