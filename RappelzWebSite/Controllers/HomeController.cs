using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using RappelzWebSite.Models;
using AutoMapper.Mappers;
using Microsoft.Ajax.Utilities;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using RappelzCore.Data;

namespace RappelzWebSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string msg)
        {

            return View();
        }
        
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
