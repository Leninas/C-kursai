using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 4;
            var b = 5;
            var sum = a + b;
            var min = a-b;
            Console.WriteLine("{0} + {1} = {2}",a,b,sum);
            Console.WriteLine("{0} - {1} = {2}", a, b, min);
        }
    }
}
