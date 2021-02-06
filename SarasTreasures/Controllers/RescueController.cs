using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SarasTreasures.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace SarasTreasures.Controllers
{
    public class RescueController : Controller
    {
        private UserManager<AppUser> userManager;
        IStoryRepository repo;

        public RescueController(UserManager<AppUser> userMngr, IStoryRepository r)
        {
            userManager = userMngr;
            repo = r;
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

        [Authorize]
        public IActionResult HappyTail()
        {
            return View();
        }

        [Authorize]  // Is this necessary if the HttpGet must Authorize?
        [HttpPost]
        public async Task<IActionResult> HappyTail(Story model)
        {
            // if model is valid, store in database
            if (ModelState.IsValid)
            {
                // Add logged in user to the model
                model.User = await userManager.GetUserAsync(User);
                // Add date and time of submission
                model.Date = DateTime.Now;
                // Add model to the database
                repo.AddStory(model);
                // Redirect user to the HappyTails view
                return Redirect("HappyTails");
            }
            return View(model);
        }

        public IActionResult HappyTails()
        {
            List<Story> stories = repo.Stories.OrderByDescending(s => s.StoryID).ToList();
            return View(stories);
        }

        [HttpPost]
        public IActionResult HappyTails(string search)
        {
            List<Story> results = null;
            // Check if search is empty or whitespace
            if (search != null && search.Trim() != "")
            {
                // search for user
                results = (from s in repo.Stories
                           where s.User.UserName.Contains(search)
                           select s).ToList();
                // if not user, search date
                if (results.Count == 0)
                    results = (from s in repo.Stories
                               .AsEnumerable()
                               where s.Date.ToString().Contains(search)
                               select s).ToList();
                // if not date, search title
                if (results.Count == 0)
                    results = (from s in repo.Stories
                              where s.Title.Contains(search)
                              select s).ToList();
                // if not title, search story
                if (results.Count == 0)
                    results = (from s in repo.Stories
                               where s.Text.Contains(search)
                               select s).ToList();
            }
            else
            {
                results = repo.Stories.ToList();
            }
            return View(results);
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
        public IActionResult AnimalQuiz(QuizVM q)
        {
            q.CheckAnswers();
            return View(q);
        }
    }
}
