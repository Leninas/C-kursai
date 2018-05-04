using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite neigama skaiciu:");
            var sk = Convert.ToInt32(Console.ReadLine());
            while (sk < 1)
            {
                Console.Write(sk+" ");
                sk++;
            }
        }
    }
}
