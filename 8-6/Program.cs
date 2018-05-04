using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reziu pradzia (nurodyti):");
            var prad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Reziu pabauga (nurodyti):");
            var pab = Convert.ToInt32(Console.ReadLine());
            if (prad >= pab)
            {
                Console.WriteLine("Reziu pabaiga nurodyta klaidingai, t.y. mazesne arba lygi pradziai.");
            }
            for (int i = prad; i < pab; i++)
            {
                if ((i % 2 != 0) ||(i % 8 == 0))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
