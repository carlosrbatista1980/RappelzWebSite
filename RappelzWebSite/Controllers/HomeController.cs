using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using RappelzWebSite.Models;
using AutoMapper.Mappers;
using RappelzCore.Data;

namespace RappelzWebSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult GetResult(FormTestViewModel formTestViewModel)
        {
            /*

            var ftm = new FormTestModel();
            var mapConfig = new MapperConfiguration(cfg => cfg.CreateMap<FormTestViewModel, FormTestModel>());
            var _formTestViewModel = formTestViewModel;
            var maper = mapConfig.CreateMapper();

            maper.Map(_formTestViewModel, ftm);

            ValuesController vcController = new ValuesController();
            vcController.InsertResult(ftm);

            mapConfig = new MapperConfiguration(cfg => cfg.CreateMap<FormTestModel, FormTestViewModel>());
            maper = mapConfig.CreateMapper();

            maper.Map(ftm, _formTestViewModel);

            formTestViewModel = _formTestViewModel;
            */

            return View(nameof(Index));

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
