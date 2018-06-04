using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00__Anna
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nurodykite skaiciu");
            int sk = int.Parse(Console.ReadLine());
            for (int i = sk; i >= 0; i--)
            {
                if (ArTvarkingasSkaicius(i))
                {
                    Console.WriteLine("Tvarkingas skaicius" + i);
                    break;
                }
            }
        }

        static bool ArTvarkingasSkaicius(int sk)
        {
            int sk1 = sk % 10;
            int sk2 = sk % 100 / 10;

            if (sk >= sk2)
            {
                sk /= 10;
                if (sk != 0)
                {
                    return ArTvarkingasSkaicius(sk);
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
