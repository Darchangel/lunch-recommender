namespace LunchRecommender.Models
{
    public class LunchPlace
    {
        public LunchPlace(string name, string area, LunchPrice price, LunchSpeed speed)
        {
            Name = name;
            Area = area;
            Price = price;
            Speed = speed;
        }

        public string Name { get; }
        public string Area { get; }
        public LunchPrice Price { get; }
        public LunchSpeed Speed { get; }
    }
}