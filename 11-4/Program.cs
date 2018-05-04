using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var sk = new int[] { 1, 2, 3, 4, 5, 6 };

            var sum = sk.Sum();
            Console.WriteLine(sum);

            var sum1 = 0;
            for (int i = 0; i < sk.Length; i++)
            {
                sum1 += sk[i];
            }
            Console.WriteLine(sum1);

            var min = sk[0];
            foreach (var ska in sk) 
            {
                min = ska;
            }
            Console.WriteLine(min);


        }
    }
}
