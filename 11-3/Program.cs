using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite kieki");
            int kiek = Convert.ToInt32(Console.ReadLine());

            string[] tekstas = new string[kiek];

            for (var i = 0; i < tekstas.Length; i++)
            {
                Console.WriteLine("iveskite teksta - ");
                tekstas[i] = Console.ReadLine();
            }
        }
    }
}
