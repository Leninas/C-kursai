using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var sk = Convert.ToInt32(Console.ReadLine());
            while (sk % 9 != 0)
            {
                sk = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("skaičius dalinasi iš 9");
        }
    }
}
