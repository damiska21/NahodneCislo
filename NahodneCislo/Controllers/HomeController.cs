using Microsoft.AspNetCore.Mvc;
using NahodneCislo.Models;

namespace NahodneCislo.Controllers
{
    public class HomeController : Controller //třída dědí vlastnosti od třídy controller
    {
        public IActionResult Index() {
            Generator generator = new Generator();
            /*způsoby, jak přenést data
            ViewData - na způsob dictionary
            ViewBag - kolekce využívající dynamičnosti .netu, ukládáme do vlastností
            TempData - předání dat u přesměrování, po konci requestu se mažou
            */
            ViewBag.Cislo = generator.VratCislo();
            return View();
        }
        public IActionResult Umocni(int x)
        {
            Generator generator = new Generator();
            ViewBag.Umocneno = generator.Umocni(x);
            return View();
        }
    }
}