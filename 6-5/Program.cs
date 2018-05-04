using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            if (a>b||a==0)
            {
                Console.WriteLine("4.1");
            }
            if (b > a || b == 5)
            {
                Console.WriteLine("4.2");
            }
            if (a > b && a == 20)
            {
                Console.WriteLine("4.3");
            }
            if (b>a&&b<100)
            {
                Console.WriteLine("4.4");
            }
        }
    }
}
