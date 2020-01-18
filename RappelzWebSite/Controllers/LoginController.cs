using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RappelzCore.Services;
using RappelzWebSite.Models;
using Microsoft.EntityFrameworkCore;

namespace RappelzWebSite.Controllers
{
    public class LoginController : Controller
    {
        public LoginService _loginService;

        public LoginController()
        {
            LoginService loginService = new LoginService();
            _loginService = loginService;
        }

        public IActionResult Login(LoginViewModel model)
        {


            if (!string.IsNullOrEmpty(model.account))
            {

            }

            return View(model);
        }

        public IActionResult CreateAccount(LoginViewModel login)
        {
            _loginService.Gett(login);

            return RedirectToAction("Login", login);
        }
    }
}