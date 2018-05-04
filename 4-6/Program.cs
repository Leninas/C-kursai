using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Convert.ToDouble(Console.ReadLine());
            var b = Convert.ToDouble(Console.ReadLine());
            var c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine((a+b+c)/3);
            Console.WriteLine(Math.Round((a + b + c) / 3,2));
        }
    }
}
