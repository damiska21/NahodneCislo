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
            ViewBag.Umocneno = x*x;
            return View();
        }
        public IActionResult Secti(int x, int y)
        {
            ViewBag.Secteno = x + y;
            return View();
        }
    }
}