using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite teigama skaiciu:");
            var sk = Convert.ToInt32(Console.ReadLine());
            while (sk>0)
            {
                Console.WriteLine(sk);
                sk--;
            }
        }
    }
}
