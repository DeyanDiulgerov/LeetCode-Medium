using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeImportanceDFS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employees1 = new List<Employee>()
            {
                new Employee()
                {
                    id = 1,
                    importance = 5,
                    subordinates = new List<int>(){2, 3}
                },
                new Employee()
                {
                    id = 2,
                    importance = 3,
                    subordinates = new List<int>(){}
                },
                new Employee()
                {
                    id = 3,
                    importance = 3,
                    subordinates = new List<int>(){}
                }
            };
            var employees2 = new List<Employee>()
            {
                new Employee()
                {
                    id = 1,
                    importance = 2,
                    subordinates = new List<int>(){5}
                },
                new Employee()
                {
                    id = 5,
                    importance = -3,
                    subordinates = new List<int>(){}
                },
            };
            var employees3 = new List<Employee>()
            {
                new Employee()
                {
                    id = 1,
                    importance = 5,
                    subordinates = new List<int>(){2,3}
                },
                new Employee()
                {
                    id = 2,
                    importance = 3,
                    subordinates = new List<int>(){4}
                },
                new Employee()
                {
                    id = 3,
                    importance = 4,
                    subordinates = new List<int>(){}
                },
                new Employee()
                {
                    id = 4,
                    importance = 1,
                    subordinates = new List<int>(){}
                },
            };
            Console.WriteLine(EmployeeImportanceDFS(employees3, 1));
            Console.WriteLine(EmployeeImportanceDFS(employees1, 1));
            Console.WriteLine(EmployeeImportanceDFS(employees2, 5));
        }
        public static int EmployeeImportanceDFS(List<Employee> employees, int id)
        {
            // KEYS AND ROOMS DFS
            // DFS DFS DFS DFS DFS DFS DFS
            var ourEmployee = employees.First(x => x.id == id);
            var seen = new HashSet<int>();
            seen.Add(id);
            void dfs(IList<int> sub)
            {
                foreach (var newId in sub)
                {
                    if (!seen.Contains(newId))
                    {
                        seen.Add(newId);
                        dfs(employees.First(x => x.id == newId).subordinates);
                    }
                }
            }
            dfs(ourEmployee.subordinates);
            int result = 0;
            foreach (int subordinateId in seen)
                result += employees.First(x => x.id == subordinateId).importance;
            return result;
        }
        // Definition for Employee.
        public class Employee
        {
            public int id;
            public int importance;
            public IList<int> subordinates;
        }
    }
}
