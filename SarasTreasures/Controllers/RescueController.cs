using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SarasTreasures.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SarasTreasures.Controllers
{
    public class RescueController : Controller
    {
        StoryContext context;

        public RescueController(StoryContext c)
        {
            context = c;
        }


        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Adopt()
        {
            return View();
        }


        public IActionResult HappyTail()
        {
            return View();
        }

        [HttpPost]
        public IActionResult HappyTail(Story model)
        {
            model.Date = DateTime.Now;
            // store in database
            context.HappyTails.Add(model);
            context.SaveChanges();
            return Redirect("HappyTails");
        }

        public IActionResult HappyTails()
        {
            var happyTails = context.HappyTails.Include(happyTails => happyTails.UserName).ToList();
            return View(happyTails);
        }


        public IActionResult Resources()
        {
            return View();
        }


        [HttpGet]
        public IActionResult AnimalQuiz()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AnimalQuiz(Quiz q)
        {
            q.CheckAnswers();
            return View(q);
        }
    }
}
