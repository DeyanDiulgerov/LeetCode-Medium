using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayTableOfFoodOrdersInARestaurant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var orders1 = new List<IList<string>>()
            {
                new List<string>() { "David", "3", "Ceviche" },
                new List<string>() { "Corina","10","Beef Burrito" },
                new List<string>() { "David","3","Fried Chicken"},
                new List<string>() { "Carla","5","Water" },
                new List<string>() { "Carla","5","Ceviche"},
                new List<string>() { "Rous","3","Ceviche"},
            };
            var orders2 = new List<IList<string>>()
            {
                new List<string>() { "James","12","Fried Chicken" },
                new List<string>() { "Ratesh","12","Fried Chicken" },
                new List<string>() { "Amadeus","12","Fried Chicken"},
                new List<string>() { "Adam","1","Canadian Waffles" },
                new List<string>() { "Brianna","1","Canadian Waffles"},
            };
            var orders3 = new List<IList<string>>()
            {
                new List<string>() { "Laura","2","Bean Burrito"},
                new List<string>() {"Jhon","2","Beef Burrito" },
                new List<string>() { "Melissa","2","Soda"},
            };
            var orders4 = new List<IList<string>>()
            {
                new List<string>() {"pKKgO","1","qgGxK"},
                new List<string>() {"ZgW","3","XfuBe"},
            };
            foreach (var item in DisplayTableOfFoodOrdersInARestaurant(orders4))
                Console.WriteLine(String.Join(",", item));
            foreach (var item in DisplayTableOfFoodOrdersInARestaurant(orders1))
                Console.WriteLine(String.Join(",", item));
            foreach (var item in DisplayTableOfFoodOrdersInARestaurant(orders2))
                Console.WriteLine(String.Join(",", item));
            foreach (var item in DisplayTableOfFoodOrdersInARestaurant(orders3))
                Console.WriteLine(String.Join(",", item));
        }

        public static IList<IList<string>> DisplayTableOfFoodOrdersInARestaurant(IList<IList<string>> orders)
        {
            var tablesAndMealsMap = new Dictionary<int, List<string>>();
            var resultList = new List<IList<string>>();
            var foods = new HashSet<string>();

            foreach (var order in orders)
            {
                foods.Add(order[2]);

                if (!tablesAndMealsMap.ContainsKey(int.Parse(order[1])))
                    tablesAndMealsMap.Add(int.Parse(order[1]), new List<string>() { order[2] });
                else
                    tablesAndMealsMap[int.Parse(order[1])].Add(order[2]);
            }
            var allMeals = foods.OrderBy(x => x, StringComparer.Ordinal).ToList();

            allMeals.Insert(0, "Table");
            resultList.Add(allMeals);

            foreach (var kvp in tablesAndMealsMap.OrderBy(x => x.Key))
            {
                var ordered = new List<string>();
                ordered.Add(kvp.Key.ToString());
                for (int i = 1; i < allMeals.Count(); i++)
                {
                    if (kvp.Value.Contains(allMeals[i]))
                        ordered.Add(kvp.Value.Count(x => x == allMeals[i]).ToString());
                    else
                        ordered.Add("0");
                }
                resultList.Add(ordered);
            }
            return resultList;
        }
    }
}
