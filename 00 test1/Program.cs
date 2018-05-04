using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_test1
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum1 = 0;
            for (int i = 1; i < 101; i++)
            {
                sum1 += i * i;
            }
            Console.WriteLine("sum1: " + sum1);

            var sum2 = 0;
            for (int i = 1; i < 101; i++)
            {
                sum2 += i;
            }
            Console.WriteLine("sum2: " + sum2*sum2);

            Console.WriteLine("rezultatas: " + (sum2*sum2 - sum1));
        }
    }
}
