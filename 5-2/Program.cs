using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var amz = Convert.ToInt16(Console.ReadLine());
            if (amz > 18)
            {
                Console.WriteLine("jus galite balsuoti");
            }
        }
    }
}
