using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var temp = new int[]{ 20, 22, 30, 29, 25, 30, 23 };

            var min = temp.Min();
            Console.WriteLine(min);

            var max = temp.Max();
            Console.WriteLine(max);

            var vid = temp.Average();
            Console.WriteLine(Math.Round(vid,2));

            var vidsk1 = 0;
            foreach (var tempone in temp)
            {
                if (tempone<vid)
                {
                    vidsk1 += 1;
                }
            }
            Console.WriteLine(vidsk1);

            var vidsk2 = 0;
            foreach (var tempone in temp)
            {
                if (tempone > vid)
                {
                    vidsk2 += 1;
                }
            }
            Console.WriteLine(vidsk2);
        }
    }
}
