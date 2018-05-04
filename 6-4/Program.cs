using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());
            var vid = (a + b + c) / 3;
            if (vid >= 8 && vid <= 10)
            {
                Console.WriteLine("Gautas vidurkis yra 8-10: " + vid);
            }
            else if (vid >= 5 && vid <= 8)
            {
                Console.WriteLine("Gautas vidurkis yra 5-8: " + vid);
            }
            else if (vid < 5)
            {
                Console.WriteLine("Gautas vidurkis yra < 5: " + vid);
            }
        }

    }
}
