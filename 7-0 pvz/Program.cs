using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_0_pvz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reiksmiu skaiciai yra:\n1 - vanduo\n2 - kava\n3 - arbata\n");
            Console.WriteLine("Pasirinkite reiksmes skaiciu:");
            var sk = Convert.ToInt32(Console.ReadLine());
            switch (sk)
            {
                case 1:
                    Console.WriteLine("vanduo");
                    break;
                case 2:
                    Console.WriteLine("kava");
                    break;
                case 3:
                    Console.WriteLine("arbata");
                    break;
                default:
                    Console.WriteLine("Netinkamai pasirinkote");
                    break;
            }
        }
    }
}
