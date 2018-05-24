using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DateTime> datos = new List<DateTime>()
            {
                new DateTime(year: 1995, month: 12, day: 02),
                new DateTime(year: 2000, month: 12, day: 02),
                new DateTime(year: 2018, month: 12, day: 02),
                new DateTime(year: 1996, month: 12, day: 02),
                new DateTime(year: 2016, month: 12, day: 02),
            };

            IEnumerable<DateTime> siendien = datos.Where(x => x == DateTime.Today);
            IEnumerable<DateTime> antradiena = datos.Where(x => x.Day ==2);
            IEnumerable<DateTime> tarpas = datos.Where(x => (x.Year > 1990 && x.Year < 2015)).OrderBy(x => x.Year);

            var data = tarpas.All(x =>
            {
                Console.WriteLine(x);
                return true;
            });

        }
    }
}
