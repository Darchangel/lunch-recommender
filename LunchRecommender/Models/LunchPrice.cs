using System.ComponentModel;

namespace LunchRecommender.Models
{
    public enum LunchPrice
    {
        [DisplayName("cheaply")]
        Low,
        [DisplayName("at an OK price")]
        Medium,
        [DisplayName("at a higher price")]
        High
    }
}