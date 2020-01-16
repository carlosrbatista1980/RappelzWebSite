using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RappelzWebSite.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult News()
        {
            return View();
        }
    }
}