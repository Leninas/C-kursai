using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Klase rezultatas = new Klase(1, 'A', 8, new DateTime(year: 2017, month: 09, day: 01),
                new List<string>() { "Inga", "Darius", "Daiva", "Nikolajus", "Petras", "Jonas", "Rolandas", "Ruslanas" },
                new int[8] { 6, 10, 6, 7, 4, 9, 5, 8 });

            Console.WriteLine(rezultatas.MoksluTrukme());
        }
    }
}
