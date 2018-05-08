using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_1
{
    class Suo
    {
        public int Amzius;
        public string Veisle;
        public string Vardas;

        public Suo(string vardas, string veisle, int amzius)
        {
            Vardas = vardas;
            Veisle = veisle;
            Amzius = amzius;
        }

        public void SuoInfo()
        {
            Console.WriteLine("Suo: {0}, {1}, {2}", Vardas, Veisle, Amzius);
        }

        public Suo()
        {
            Console.WriteLine("Nurodykite varda");
            Vardas = Console.ReadLine();

            Console.WriteLine("Nurodykite veisle");
            Veisle = Console.ReadLine();

            Console.WriteLine("Nurodykite amziu");
            Amzius = Convert.ToInt32(Console.ReadLine());
        }
    }
}
