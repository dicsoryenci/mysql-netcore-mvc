using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvcMySQL.Models;

namespace mvcMySQL.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
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

        [HttpGet]
        public JsonResult getClientes(){
            List<Cliente> lstClientes = new List<Cliente>();
            lstClientes.Add(new Cliente("1234","Emmanuel Amperez"));
            lstClientes.Add(new Cliente("4134","Diego Amperez"));
            lstClientes.Add(new Cliente("1233","Juan Amperez"));
            lstClientes.Add(new Cliente("4433","Allan Amperez"));
            lstClientes.Add(new Cliente("2233","Luis Amperez"));

            return Json(lstClientes.ToArray());
        }
    }
}
