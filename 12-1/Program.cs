using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var sk = new List<int>();
            var atsObj = new Random();
            var kiek = atsObj.Next(2,4);

            for (int i = 0; i <= kiek; i++)
            {
                var skone = Convert.ToInt32(Console.ReadLine());
                sk.Add(skone);
            }

            Console.WriteLine("Lentele1");
            foreach (var skone in sk)
            {
                Console.WriteLine(skone);
            }

            Console.WriteLine("Lentele2");
            var sk1 = new List<int>();
            var atsObj1 = new Random();
            var kiek1 = atsObj1.Next(4, 8);

            for (int i1 = 0; i1 <= kiek1; i1++)
            {
                var skone1 = Convert.ToInt32(atsObj1.Next(20));
                sk1.Add(skone1);
            }

            foreach (var skone1 in sk1)
            {
                Console.WriteLine(skone1);
            }

            Console.WriteLine("Lentele 2 min - " + sk1.Min());
        }
    }
}
