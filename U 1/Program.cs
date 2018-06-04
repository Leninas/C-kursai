using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U_1
{
    class Program
    {
        static void Main(string[] args)

        {
            //Console.WriteLine("Nurodykite mokinių skaiciu:");
            //var m = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Nurodykite lapu skaiciu:");
            //var n = Convert.ToInt32(Console.ReadLine());

            //var today = DateTime.Today;
            //Console.WriteLine(today);

            //DateTime siandien = new DateTime(year: 1995, month: 12, day: 02);
            //siandien = DateTime.Today;
            //Console.WriteLine(siandien);

            DateTime today = DateTime.Today;
            string sqlFormattedDate = today.ToString("yyyy-MM-dd"); // <- No Date.To

            Console.WriteLine(today);

        }
    }
}
