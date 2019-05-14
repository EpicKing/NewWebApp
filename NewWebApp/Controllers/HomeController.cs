using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewWebApp.Models;

namespace NewWebApp.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult HeatConsumptions()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Organizations()
        {
            return View();
        }

        [HttpGet]
        public IActionResult TypeOfProducts()
        {
            return View();
        }

        [HttpPost]
        public string Organizations(string name, string type, string address)
        {
            return "Организация с названием \"" + name + "\" и видом собственности \"" + type 
                   + "\" расположенная по адресу \"" + address + "\"  добавлена в базу";
        }

        [HttpPost]
        public string TypeOfProducts(string name, string unit)
        {
            return "Вид продукции с названием \"" + name + "\" и видом единицей измерения \"" + unit
                   + "\" добавлен в базу";
        }

        [HttpPost]
        public string HeatConsumption(int total, int year, int quarter)
        {
            return "Всего потреблено энергии  \"" + total + "\" в \"" + year
                   + "\" году в \"" + quarter + "\" квартале. Запись добавлена в базу";
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
