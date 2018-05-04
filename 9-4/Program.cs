using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "";
            string c = "";

            while (c != "exit")
            {
                Console.Write("Irasykite zodi arba exit: ");
                c = Console.ReadLine();
                a += (c != "exit") ? c + " " : "";
            }
            Console.WriteLine(a);
        }
    }
}
