using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int rinkis;

            do
            {
                Console.WriteLine("1 - šuo, 2 - katė, 3 - žiurkėnas");
                rinkis = Convert.ToInt32(Console.ReadLine());

                if (rinkis < 1 || rinkis > 3)
                {
                    Console.WriteLine("Blogas pasirinkimas");
                }

            } while (rinkis < 1 || rinkis > 3);
            switch (rinkis)
            {
                case 1:
                    Console.WriteLine("šuo");
                    break;
                case 2:
                    Console.WriteLine("katė");
                    break;
                case 3:
                    Console.WriteLine("žiurkėnas");
                    break;
                default:
                    rinkis = Convert.ToInt32(Console.ReadLine());
                    break;
            }
        }
    }
}
