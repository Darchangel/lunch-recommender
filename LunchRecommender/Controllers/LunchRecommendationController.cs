using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using LunchRecommender.Models;

using Microsoft.AspNetCore.Mvc;

namespace LunchRecommender.Controllers
{
    public class LunchRecommendationController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Suggest()
        {
            return View("Index", new LunchPlace("Boguette", "Next to Markthal", LunchPrice.Medium, LunchSpeed.Fast));
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
