using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RappelzWebSite.Models;
using Microsoft.EntityFrameworkCore;
using RappelzCore.Data;
using RappelzCore.Repositories;
using RappelzCore.Repositories.Interfaces;

namespace RappelzWebSite.Controllers
{
    public class LoginController : Controller
    {
        public LoginController(ServiceInitialize service)
        {
        }
        
        public IActionResult Login(LoginViewModel model)
        {
            return View(model);
        }

        [HttpPost]
        public IActionResult CreateAccount(LoginViewModel model)
        {
            return View();
        }

        public IActionResult TermsAndConditions()
        {
            return View();
        }

        public IActionResult SignIn()
        {
            return View();
        }

        public IActionResult ForgotPassword()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
    }
}