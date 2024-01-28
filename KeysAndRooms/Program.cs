using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeysAndRooms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rooms1 = new List<IList<int>>()
            {
                new List<int>() {2},
                new List<int>() { },
                new List<int>() {1},
            };
            var rooms2 = new List<IList<int>>()
            {
                new List<int>() {1,3},
                new List<int>() {3,0,1},
                new List<int>() {2},
                new List<int>() {},
            };
            Console.WriteLine(KeysAndRooms(rooms1));
            Console.WriteLine(KeysAndRooms(rooms2));

        }
        //DFS
        public static bool CanVisitAllRooms(IList<IList<int>> rooms)
        {
            HashSet<int> visited = new HashSet<int>();
            void dfs(int room)
            {
                visited.Add(room);
                foreach (var i in rooms[room])
                {
                    if (!visited.Contains(i))
                        dfs(i);
                }
            }
            dfs(0);
            return visited.Count() == rooms.Count();
        }
        public static bool KeysAndRooms(IList<IList<int>> rooms)
        {
            HashSet<int> allKeys = new HashSet<int>();
            allKeys.Add(0);
            int i = 0;
            while (allKeys.Count < rooms.Count && i < allKeys.Count)
            {
                for (int j = 0; j < rooms[allKeys.ToArray()[i]].Count; j++)
                    allKeys.Add(rooms[allKeys.ToArray()[i]][j]);
                i++;
            }
            return allKeys.Count() == rooms.Count();
        }
    }
}
