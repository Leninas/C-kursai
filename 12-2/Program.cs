using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var paz = new List<int>();
            var sardid = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < sardid; i++)
            {
                var pazone = Convert.ToInt32(Console.ReadLine());
                paz.Add(pazone);
            }

            Console.WriteLine("Lentele");
            foreach (var pazone in paz)
            {
                Console.WriteLine(pazone);
            }
        }
    }
}
