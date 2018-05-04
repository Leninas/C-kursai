using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite teigiama skaiciu");
            var sk = Convert.ToInt32(Console.ReadLine());

            if (sk <= 0)
            {
                Console.WriteLine("BLOGAI");
            }
            if (sk >= 0)
            {
                Console.WriteLine("GERAI");
            }
            if (sk % 2 == 0)
            {
                Console.WriteLine("lyginis");
            }
            if (sk % 4 == 0)
            {
                Console.WriteLine("dalinasi is 4");
            }
            if (sk > 10)
            {
                Console.WriteLine("didesnis uz 10");
            }
        }
    }
}
