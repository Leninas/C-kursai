using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());

            if (a == b)
            {
                Console.WriteLine("1. {0} = {1}",a,b);
            }
            if (b == c)
            {
                Console.WriteLine("2. {0} = {1}",b,c);
            }
            if (a > b)
            {
                Console.WriteLine("3. {0} > {1}",a,b);
            }
            if (b > c*2)
            {
                Console.WriteLine("4. {0} = {1}*2", b, c);
            }
            if (a % 2 == 0)
            {
                Console.WriteLine("5. lyginis");
            }
            if (b % 2 != 0)
            {
                Console.WriteLine("6. nelyginis");
            }
            if (c > 0)
            {
                Console.WriteLine("7. teigiamas");
            }
            if (c < 0)
            {
                Console.WriteLine("8. neigiamas");
            }
        }
    }
}