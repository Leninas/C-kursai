using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bako talpa: ");
            var talpa = Convert.ToInt32(Console.ReadLine());

            var km = new int[] { 23, 34, 45 };

            var ilg = km.Max();
            Console.WriteLine(ilg);
            var trump = km.Min();
            Console.WriteLine(trump);
            var viso = km.Sum();
            Console.WriteLine(viso);
            var vidsan = (double)talpa *100 / viso;
            Console.WriteLine(vidsan);
        }
    }
}
