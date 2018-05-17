using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_4_Uzduotis_Interface_FileWrite
{


    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite darbuotojo ID ir varda (per tarpa):");
            string[] data = Console.ReadLine().Split(' ');

            Darbuotojas darb = new Darbuotojas(int.Parse(data[0]), data[1]);
            darb.PrintOutData();
        }
    }
}
