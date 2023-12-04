using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DestroyingAsteroids
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DestroyingAsteroids(10, new int[] { 3, 9, 19, 5, 21 }));
            Console.WriteLine(DestroyingAsteroids(5, new int[] { 4, 9, 23, 4 }));
        }

        public static bool DestroyingAsteroids(int mass, int[] asteroids)
        {
            Array.Sort(asteroids);
            long newMass = mass;
            var listed = new List<int>(asteroids);
            for (int j = 0; j < listed.Count(); j++)
            {
                if (newMass >= listed[j])
                {
                    newMass += listed[j];
                    listed.Remove(listed[j]);
                    j--;
                }
                else
                    return false;

            }
            return true;
        }
    }
}
