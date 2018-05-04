using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var paz = new int[] { 3, 7, 9, 10, 4, 5, 8, 10 };

            var max = paz.Max();
            Console.WriteLine(max);

            var virs10 = 0;
            foreach (var pazone in paz)
            {
                if (pazone==10)
                {
                    virs10 += 1;
                }
            }
            Console.WriteLine(virs10);

            var neig = 0;
            foreach (var pazone in paz)
            {
                if (pazone < 4)
                {
                    neig += 1;
                }
            }
            Console.WriteLine(neig);

            var vidurk = paz.Average();
            Console.WriteLine(vidurk);

            var sum = paz.Sum();
            Console.WriteLine(sum);
            var kiek = paz.Length;
            Console.WriteLine(kiek);
            var vidurk1 = (sum / kiek);
            Console.WriteLine(vidurk1);
        }
    }
}
