using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pin :");
            var pin = Console.ReadLine();
            Console.WriteLine("Vardas :");
            var vardas = Console.ReadLine();
            Console.WriteLine("Metai :");
            var metai = Console.ReadLine();

            Console.WriteLine("Pin :" + pin);
            Console.WriteLine("Vardas :" + vardas);
            Console.WriteLine("Metai :" + metai);

            Console.WriteLine("Skaiciai :");
            var sk = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(sk*8666);

        }
    }
}
