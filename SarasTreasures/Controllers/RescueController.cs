﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SarasTreasures.Models;
using SarasTreasures.Data;

namespace SarasTreasures.Controllers
{
    public class RescueController : Controller
    {
        IStoryRepository repo;

        public RescueController(IStoryRepository r)
        {
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


        public IActionResult HappyTail()
        {
            return View();
        }

        [HttpPost]
        public IActionResult HappyTail(Story model)
        {
            // if valid, store in database
            if (ModelState.IsValid)
            {
                // TODO: add logged in user
                //model.User.UserName = User.Identity.Name;
                // add date and time of submission
                model.Date = DateTime.Now;
                repo.AddStory(model);
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

            if (search != null)
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
        public IActionResult AnimalQuiz(Quiz q)
        {
            q.CheckAnswers();
            return View(q);
        }
    }
}
