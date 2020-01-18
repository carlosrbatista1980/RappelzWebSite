using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Rewrite.Internal.ApacheModRewrite;
using RappelzCore.Helpers;
using RappelzCore.Repositories;
using RappelzCore.Repositories.Interfaces;

namespace RappelzCore.Services
{
    public class LoginService
    {
        public LoginService()
        {
        }

        public object Gett<TObject>(TObject obj)
        {
            var o = new Account();
            MapHelper.MapFrom(obj, o);
            o.account = "HEHEHEEHEH";
            o.password = "passworddddd";
            o.email = "emaillllll";
            MapHelper.MapFrom(o, obj);
            return obj;
        }
        
    }
}
