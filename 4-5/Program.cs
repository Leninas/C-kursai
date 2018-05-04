using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skaicius:");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = 1;
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
            b += 1;
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
            b += 1;
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
            b += 1;
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
            b += 1;
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
        }
    }
}
