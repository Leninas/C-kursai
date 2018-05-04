using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var atsk = new Random();
            var atsk1 = atsk.Next(1, 11);
            var sk = Convert.ToInt32(Console.ReadLine());
            while (atsk1 != sk)
            {
                Console.WriteLine("Neatspejai");
                sk = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Atspejai - "+atsk1);
        }
    }
}
