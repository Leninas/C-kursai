using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_0
{
    class Program
    {
        static void Main(string[] args)
        {
            var progr = new Program();
            progr.Labas();
            progr.Atia();

            Console.WriteLine();

            Labas2();
            Program.Labas2();
        }

        //metodai

        public static void Labas2()
        {
            Console.WriteLine("Labas 2");
        }


        public void Labas()
        {
            Console.WriteLine("Labas");
        }

        public void Atia()
        {
            Console.WriteLine("Atia");
        }
    }
}
