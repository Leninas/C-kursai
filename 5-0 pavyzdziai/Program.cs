using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_0_pavyzdziai
{
    class Program
    {
        static void Main(string[] args)
        {
            if (5 > 3)
            {
                Console.WriteLine("geras");
                Console.WriteLine("geras");
                Console.WriteLine("geras");
                Console.WriteLine("geras");
            }
            var suo = "mano";
            Console.WriteLine(suo.ToUpper()); //konvertioja i dideles raides
            Console.WriteLine(suo.ToLower());
        }
    }
}
