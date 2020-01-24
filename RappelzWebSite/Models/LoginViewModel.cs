using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using RappelzCore.Repositories;
using RappelzWebSite.Models.Interfaces;

namespace RappelzWebSite.Models
{
    //public class LoginViewModel : ViewModelBase
    public class LoginViewModel : IEquatable<LoginViewModel>
    {
        public LoginViewModel()
        {
        }

        public int account_id { get; set; } //[Auth].[Account].account_id

        [Required(ErrorMessage = "Account is required.")]
        public string account { get; set; } //[Auth].[Account].account

        [Required(ErrorMessage = "Password is required.")]
        public string password { get; set; } //[Auth].[Account].password

        [EmailAddress(ErrorMessage = "Email is required and must be valid.")]
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

        public bool Equals(LoginViewModel other)
        {
            throw new NotImplementedException();
        }
        //public int ViewModelChanged
        //{
        //    get
        //    {
        //        return __EventGetter;
        //    }
        //    set
        //    {
        //        SetProperty(ref __EventGetter, value);
        //    }
        //}
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<string> GetUserIdAsync(LoginViewModel user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetUserNameAsync(LoginViewModel user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task SetUserNameAsync(LoginViewModel user, string userName, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetNormalizedUserNameAsync(LoginViewModel user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task SetNormalizedUserNameAsync(LoginViewModel user, string normalizedName, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<IdentityResult> CreateAsync(LoginViewModel user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<IdentityResult> UpdateAsync(LoginViewModel user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<IdentityResult> DeleteAsync(LoginViewModel user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<LoginViewModel> FindByIdAsync(string userId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<LoginViewModel> FindByNameAsync(string normalizedUserName, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
