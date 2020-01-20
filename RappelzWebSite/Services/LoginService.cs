using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Rewrite.Internal.ApacheModRewrite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RappelzCore.Data;
using RappelzCore.Helpers;
using RappelzCore.Repositories;
using RappelzCore.Repositories.Interfaces;

namespace RappelzWebSite.Services
{
    public class LoginService
    {
        public AuthContext _authContext;
        public IRepository<Account> account;
        

        public LoginService(AuthContext context)
        {
            _authContext = context;
            this.account = account;
        }



        public object Login<Tobject>(Tobject viewModel)
        {
            var account = new Account();
            MapHelper.MapFrom(viewModel, account);
            return viewModel;
        }

        public object Gett<TObject>(TObject obj)
        {

            MapHelper.MapFrom(obj, new Account());
            
            //MapHelper.MapFrom(o, obj);
            return obj;
        }
        
    }
}
