using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] paz = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(paz[5]);

            string[,] markes = { { "Audi 80", "Audi 100" }, { "VW Golf", "VW Passat" } };
            Console.WriteLine(markes[1, 1]);
            Console.WriteLine("markiu kiekis: " + markes[1,0]);

            string[,] markes2 = {
                { "Audi 80", "Audi 100" },
                { "VW Golf", "VW Passat" }
            };
            Console.WriteLine(markes2[0, 0]);

            int[] mano = new int[3];
            mano[0] = 1;
            mano[1] = 5;
            mano[2] = 10;
            Console.WriteLine(mano[1]);


        }
    }
}
