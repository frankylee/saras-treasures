using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using SarasTreasures.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SarasTreasures.Controllers
{
    public class RescueController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Adopt()
        {
            return View();
        }


        public IActionResult HappyTails()
        {
            Stories model = new Stories();
            User userName = new User();
            model.UserName = userName;
            return View(model);
        }

        [HttpPost]
        public IActionResult HappyTails(Stories model)
        {
            return View(model);
        }


        public IActionResult Resources()
        {
            return View();
        }

    }
}
