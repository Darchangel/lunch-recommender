using System;
using System.Collections.Generic;

using LunchRecommender.Models;

namespace LunchRecommender.Repositories
{
    public class InMemoryLunchPlaceRepository : ILunchPlaceRepository
    {
        private readonly List<LunchPlace> _dataStore = new List<LunchPlace>
                                              {
                                                    new LunchPlace(   "Boguette",            "the Markthal",    LunchPrice.Low,    LunchSpeed.Fast),
                                                    new LunchPlace(   "Wok",                 "MediaMarkt",      LunchPrice.Low,    LunchSpeed.Fast),
                                                    new LunchPlace(   "Panini",              "Beurs",           LunchPrice.Low,    LunchSpeed.Fast),

                                                    new LunchPlace(   "Little Italy",        "Markthal",        LunchPrice.Low,    LunchSpeed.Medium),
                                                    new LunchPlace(   "Switie",              "Witte de With",   LunchPrice.Low,    LunchSpeed.Fast),
                                                    new LunchPlace(   "That Kapsalon place", "Witte de With",   LunchPrice.Low,    LunchSpeed.Medium),

                                                    new LunchPlace(   "Pizza Hut",           "Schouwburgplein", LunchPrice.Medium, LunchSpeed.Slow)
                                              };

        public LunchPlace GetRandomLunchPlace()
        {
            var random = new Random();

            return _dataStore[random.Next(_dataStore.Count)];
        }
    }
}
