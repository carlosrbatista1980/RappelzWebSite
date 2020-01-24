using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using RappelzWebSite.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using Newtonsoft.Json;
using RappelzCore.Data;
using RappelzCore.Repositories;
using RappelzCore.Repositories.Interfaces;
using RappelzWebSite.Services;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;


namespace RappelzWebSite.Controllers
{
    public class LoginController : Controller
    {
        private readonly ServiceInitialize _service;
        public UserManager<IdentityUser<LoginViewModel>> _userManager { get; set; }
        public UserClaimsPrincipalFactory<LoginViewModel> _userClaimsPrincipalFactory { get; set; }
        public SignInManager<LoginViewModel> _signInManager { get; set; }
        
        //public LoginController(ServiceInitialize service, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        public LoginController(ServiceInitialize service)
        {
            _service = service;
            //_userManager = userManager;
            //_signInManager = signInManager;
        }
        
        public IActionResult Login(LoginViewModel model)
        {
            ViewData.Model = model;
            return View();
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

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult SignUp(LoginViewModel loginViewModel)
        {
            new LoginService(_service).SignUpService(loginViewModel);
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

            return RedirectToAction("Register", loginViewModel);
            
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> SignInAsync(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser()
                {
                    Email = loginViewModel.email,
                    PasswordHash = "b49d6c03fe471ee720b5a4d56c5a9bf2",
                    UserName = loginViewModel.account,
                    EmailConfirmed = false,
                    NormalizedUserName = loginViewModel.account,
                    PhoneNumberConfirmed = false,
                    SecurityStamp = GetHashCode().ToString(),
                };
                
                //var result = await _signInManager.PasswordSignInAsync(user.UserName, user.PasswordHash, true, false);
                
                var userExists = new LoginService(_service).SignInService(loginViewModel);
                if (userExists)
                {
                    //var s = await _signInManager.PasswordSignInAsync(user, user.PasswordHash, true, false);
                    //await _signInManager.SignInAsync(user, true);
                    //wait _signInManager.SignInAsync(user, true);
                    
                    
                    //User.Claims.Where(d => d.Value == ControllerContext.HttpContext.User.Claims.GetEnumerator().Current.Value);
                    loginViewModel.SessionId = GetHashCode();
                    ViewData.Model = loginViewModel;

                    

                    return RedirectToAction("Index", "Home", ViewData.Model);
                }
            }
            
            return RedirectToAction("Login", loginViewModel);
        }


        //public ActionResult SignIn(LoginViewModel loginViewModel)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var user = new IdentityUser()
        //        {
        //            Email = loginViewModel.email,
        //            PasswordHash = loginViewModel.password,
        //            UserName = loginViewModel.account,
        //            EmailConfirmed = false,
        //            NormalizedUserName = loginViewModel.account,
        //            PhoneNumberConfirmed = false,
        //        };

        //        var result = new LoginService(_service).SignInService(loginViewModel);
        //        if (result)
        //        {
        //            var s = _signInManager.PasswordSignInAsync(user.UserName, user.PasswordHash, true, false);
        //            _signInManager.SignInAsync(user, true);
        //            ViewData["User"] = loginViewModel.account;
        //        }
        //    }

        //    return RedirectToAction("Index", "Home", loginViewModel);
        //}
    }
}