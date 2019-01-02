using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ControleAves.Models;

namespace ControleAves.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Site criado para o pequeno criador de Aves.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Meios de contato.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult BirthControl()
        {
            return View();
        }

        public IActionResult NewAve()
        {
            return View();
        }

        public IActionResult ListAve()
        {
            return View();
        }

        public IActionResult Saida()
        {
            return View();
        }

        public IActionResult NewEntrada()
        {
            return View();
        }

        public IActionResult ListEntrada()
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
