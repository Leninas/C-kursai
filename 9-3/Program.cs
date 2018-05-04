using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var sk = "t";
            while (sk == "t")
            {
                Console.WriteLine("Nurodykite 1 skaiciu:");
                var sk1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nurodykite 2 skaiciu:");
                var sk2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("skaiciavimai"); // skaiciavimai
                Console.WriteLine("Kartoti: t/n?"); // klausti ar kartoti
                sk = Console.ReadLine();
            }
        }
    }
}
