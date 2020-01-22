using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Ajax.Utilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Rewrite.Internal.ApacheModRewrite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RappelzCore.Data;
using RappelzCore.Helpers;
using RappelzCore.Repositories;
using RappelzCore.Repositories.Interfaces;
using RappelzWebSite.Models;

namespace RappelzWebSite.Services
{
    public class LoginService
    {
        private RappelzService _service;

        public LoginService(RappelzService service)
        {
            _service = service;
        }



        public object Login<Tobject>(Tobject viewModel)
        {

            var account = new Account();
            MapHelper.MapFrom(viewModel, account);
            return viewModel;
        }

        public object CreateAccount(LoginViewModel obj)
        {
            var accountExist = _service._authContext.Account.FirstOrDefault(account => account.account == obj.account);
            var emailExist = _service._authContext.Account.FirstOrDefault(account => account.email == obj.email);

            if (accountExist == null && emailExist == null)
            {
                var newRecord = new Account();
                MapHelper.MapFrom(obj, newRecord);

                //This fields cannot be null in database and must be filled.
                newRecord.IP_user = "127.0.0.1";
                newRecord.block = 0;
                newRecord.password2 = !string.IsNullOrEmpty(obj.password) ? obj.password : "0";
                newRecord.phone = DateTime.Now.TimeOfDay.ToString();
                newRecord.last_login_server_idx = 1;
                newRecord.point = 1;
                newRecord.datePassword = DateTime.Now;

                try
                {
                    _service._authContext.Account.Add(newRecord);
                    _service._authContext.SaveChanges();
                    MapHelper.MapFrom(newRecord, obj);
                    obj.dateRegisterCreated = DateTime.Now;
                    obj._EventSuccess = true;
                    obj._EventMesssage = "Successfully created account!";
                    return obj;
                }
                catch (DbUpdateException ex)
                {
                    obj._EventSuccess = false;
                    return obj;
                }
            }

            if(accountExist != null)
                obj._EventMesssage = " Account name already exists!";
            if (emailExist != null)
                obj._EventMesssage += " Email already exists!";
            return obj;
        }
    }
}
