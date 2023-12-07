using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubdomainVisitCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", SubdomainVisitCount(
                new string[] { "9001 discuss.leetcode.com" })));
            Console.WriteLine(String.Join(",", SubdomainVisitCount(
                new string[] { "900 google.mail.com", "50 yahoo.com", "1 intel.mail.com", "5 wiki.org" })));
        }

        public static IList<string> SubdomainVisitCount(string[] cpdomains)
        {
            var resultList = new List<string>();
            var domainAndVisitsMap = new Dictionary<string, int>();

            for (int i = 0; i < cpdomains.Length; i++)
            {
                var splitted = cpdomains[i].Split(' ');
                var visitedDomains = new List<string>();

                int number = int.Parse(splitted[0]);
                visitedDomains = splitted[1].Split('.').ToList();

                string substring = "";
                for (int v = visitedDomains.Count() - 1; v >= 0; v--)
                {
                    substring = substring.Insert(0, "." + visitedDomains[v]);
                    if (!domainAndVisitsMap.ContainsKey(substring))
                        domainAndVisitsMap.Add(substring, number);
                    else
                        domainAndVisitsMap[substring] += number;
                }
            }

            foreach (var kvp in domainAndVisitsMap)
            {
                var str = "";
                str += kvp.Value;
                str += " ";
                string domain = kvp.Key.Remove(0, 1);
                str += domain;
                resultList.Add(str);
            }
            return resultList;
        }
    }
}
