using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RappelzWebSite.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using RappelzCore.Data;
using RappelzCore.Repositories;
using RappelzCore.Repositories.Interfaces;
using RappelzWebSite.Services;

namespace RappelzWebSite.Controllers
{
    public class LoginController : Controller
    {
        private readonly ServiceInitialize _service;

        public LoginController(ServiceInitialize service)
        {
            _service = service;
        }
        
        public IActionResult Login(LoginViewModel model)
        {
            return View(model);
        }

        public IActionResult TermsAndConditions(LoginViewModel loginViewModel)
        {
            return View();
        }

        public IActionResult ForgotPassword(LoginViewModel loginViewModel)
        {
            return View();
        }
        
        public IActionResult Register(LoginViewModel loginViewModel)
        {
            return View(loginViewModel);
        }

        public object CreateAccount(LoginViewModel loginViewModel)
        {
            new LoginService(_service).CreateAccount(loginViewModel);
            if (loginViewModel._EventSuccess)
            {
                ViewData["Success"] = loginViewModel._EventMesssage;
                loginViewModel = null;
                return View("Register", loginViewModel);
            }

            if (!string.IsNullOrEmpty(loginViewModel._EventMesssage))
                ViewData["Error"] = loginViewModel._EventMesssage;
            else
                ViewData["Error"] = "Account was not created, internal error";

            return View("Register", loginViewModel);
        }
    }
}