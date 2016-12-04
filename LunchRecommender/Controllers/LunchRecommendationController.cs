using LunchRecommender.Models;
using LunchRecommender.Repositories;

using Microsoft.AspNetCore.Mvc;

namespace LunchRecommender.Controllers
{
    public class LunchRecommendationController : Controller
    {
        private readonly ILunchPlaceRepository _lunchPlaceRepository;

        public LunchRecommendationController(ILunchPlaceRepository lunchPlaceRepository)
        {
            _lunchPlaceRepository = lunchPlaceRepository;
        }

        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Suggest()
        {
            LunchPlace suggestedLunchPlace = _lunchPlaceRepository.GetRandomLunchPlace();

            return View("Index", suggestedLunchPlace);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}