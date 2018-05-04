using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_9
{
    class Program
    {
        static void Main(string[] args)
        {
            var suma = 0;

            for (int i = 20; i < 50; i++)
            {
                if (i % 2 == 0)
                {
                    suma += i;
                }
            }
            Console.WriteLine("Viso: " + suma);
        }
    }
}
