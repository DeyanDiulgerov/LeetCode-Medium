using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignAFoodRatingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FoodRatings restaurant = new FoodRatings(
                new string[] { "kimchi", "miso", "sushi", "moussaka", "ramen", "bulgogi" },
                new string[] { "korean", "japanese", "japanese", "greek", "japanese", "korean" },
                new int[] { 9, 12, 8, 15, 14, 7 });

            restaurant.HighestRated("korean");
            restaurant.HighestRated("japanese");
            restaurant.ChangeRating("sushi", 16);
            restaurant.HighestRated("japanese");
            restaurant.ChangeRating("ramen", 16);
            restaurant.HighestRated("japanese");
        }
        public class FoodRatings
        {
            Dictionary<string, Dictionary<string, int>> map
                = new Dictionary<string, Dictionary<string, int>>();

            public FoodRatings(string[] foods, string[] cuisines, int[] ratings)
            {
                int n = foods.Length;
                for (int i = 0; i < n; i++)
                {
                    if (map.ContainsKey(cuisines[i]))
                        map[cuisines[i]].Add(foods[i], ratings[i]);
                    else
                    {
                        var newFoodAndRating = new Dictionary<string, int>();
                        newFoodAndRating.Add(foods[i], ratings[i]);
                        map.Add(cuisines[i], newFoodAndRating);
                    }
                }
            }


            public void ChangeRating(string food, int newRating)
            {
                foreach (var kvp in map)
                {
                    if (kvp.Value.ContainsKey(food))
                    {
                        kvp.Value[food] = newRating;
                    }
                }
            }

            public string HighestRated(string cuisine)
            {
                string bestFood = "";
                int rating = 0;

                foreach (var item in map[cuisine])
                {
                    if (item.Value == rating)
                    {
                        if (String.Compare(item.Key, bestFood) < 0)
                        {
                            bestFood = item.Key;
                        }
                    }
                    else if (item.Value > rating)
                    {
                        rating = item.Value;
                        bestFood = item.Key;
                    }
                }

                return bestFood;
            }
        }
    }
}
