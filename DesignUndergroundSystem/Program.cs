using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignUndergroundSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UndergroundSystem undergroundSystem = new UndergroundSystem();
            undergroundSystem.CheckIn(45, "Leyton", 3);
            undergroundSystem.CheckIn(32, "Paradise", 8);
            undergroundSystem.CheckIn(27, "Leyton", 10);
            undergroundSystem.CheckOut(45, "Waterloo", 15);
            undergroundSystem.CheckOut(27, "Waterloo", 20);
            undergroundSystem.CheckOut(32, "Cambridge", 22);
            undergroundSystem.GetAverageTime("Paradise", "Cambridge");
            undergroundSystem.GetAverageTime("Leyton", "Waterloo");
            undergroundSystem.CheckIn(10, "Leyton", 24);
            undergroundSystem.GetAverageTime("Leyton", "Waterloo");
            undergroundSystem.CheckOut(10, "Waterloo", 38);
            undergroundSystem.GetAverageTime("Leyton", "Waterloo");

            Console.WriteLine("\n$$$$$$$$$$$$$$$$$$$$$$ SECOND: $$$$$$$$$$$$$$$$$$$$$$\n");
            UndergroundSystem undergroundSystem2 = new UndergroundSystem();
            undergroundSystem2.CheckIn(10, "Leyton", 3);
            undergroundSystem2.CheckOut(10, "Paradise", 8);
            undergroundSystem2.GetAverageTime("Leyton", "Paradise");
            undergroundSystem2.CheckIn(5, "Leyton", 10);
            undergroundSystem2.CheckOut(5, "Paradise", 16);
            undergroundSystem2.GetAverageTime("Leyton", "Paradise");
            undergroundSystem2.CheckIn(2, "Leyton", 21);
            undergroundSystem2.CheckOut(2, "Paradise", 30);
            undergroundSystem2.GetAverageTime("Leyton", "Paradise");
        }
        public class UndergroundSystem
        {
            // map every person with another map of each station and time needed
            Dictionary<int, Dictionary<string, int>> mapIdStationTime;
            Dictionary<string, double> stationAndAvgTimeMap;
            Dictionary<string, int> visitsStationCount;
            public UndergroundSystem()
            {
                mapIdStationTime = new Dictionary<int, Dictionary<string, int>>();
                stationAndAvgTimeMap = new Dictionary<string, double>();
                visitsStationCount = new Dictionary<string, int>();
            }
            public void CheckIn(int id, string stationName, int t)
            {
                //might not need if check(containsKey) cuz of constraint
                if (!mapIdStationTime.ContainsKey(id))
                {
                    var stationAndTime = new Dictionary<string, int>();
                    stationAndTime.Add(stationName, t);

                    mapIdStationTime.Add(id, stationAndTime);
                    Console.WriteLine($"Customer: {id} checked in: {stationName} at time: {t}");
                }
            }
            public void CheckOut(int id, string stationName, int t)
            {
                //might not need if check
                if (mapIdStationTime.ContainsKey(id))
                {
                    //add new Info
                    string oldStation = mapIdStationTime[id].Keys.First();
                    string route = $"{oldStation} -> {stationName}";
                    // check time
                    int oldTime = mapIdStationTime[id].Values.First();
                    //CheckOut(int t) = newTime

                    mapIdStationTime.Remove(id);

                    //might not need if check
                    if (!stationAndAvgTimeMap.ContainsKey(route))
                    {
                        stationAndAvgTimeMap.Add(route, t - oldTime);
                        visitsStationCount.Add(route, 1);
                    }
                    else
                    {
                        visitsStationCount[route]++;
                        var allTimes = stationAndAvgTimeMap[route] + (t - oldTime);
                        stationAndAvgTimeMap[route] = allTimes;
                    }

                    Console.WriteLine($"Customer: {id} traveled from {oldStation} to {stationName}" +
                        $" at time: {t - oldTime}");
                    Console.WriteLine($"Customer: {id} checked out: {stationName} at time: {t}");
                }
            }
            public double GetAverageTime(string startStation, string endStation)
            {
                string route = $"{startStation} -> {endStation}";
                Console.WriteLine($"Average Time from {startStation} to {endStation} is:" +
                    $" {stationAndAvgTimeMap[route] / visitsStationCount[route]}");

                return stationAndAvgTimeMap[route] / visitsStationCount[route];
            }
        }
    }
}
