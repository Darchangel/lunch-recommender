using LunchRecommender.Models;

namespace LunchRecommender.Repositories
{
    public interface ILunchPlaceRepository
    {
        LunchPlace GetRandomLunchPlace();
    }
}