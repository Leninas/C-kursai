using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_0
{
    class Automobilis
    {
        // rasymo rekomendacija - kuo skiriasi rasymas public, private
        // public AbcAbc (uzrasymo budas - pascal case)
        // private _abcAbc (uzrasymo budas - camel case)

        public int PagaminimoMetai;
        public string Spalva;
        public string Marke;
        public string VIN;
        public string ValstybinisNumeris;

        public Automobilis()
        {

        }

        public Automobilis(int pagaminimoMetai, string spalva, string marke, string vin, string valstybinisNumeris)
        {
            PagaminimoMetai = pagaminimoMetai;
            Spalva = spalva;
            Marke = marke;
            VIN = vin;
            ValstybinisNumeris = valstybinisNumeris;
        }

        public void Info()
        {
            Console.WriteLine("Auto {2}, gam. {0}, spalva - {1}, vin - {3}, v/n {4}", PagaminimoMetai, Spalva, Marke, VIN, ValstybinisNumeris);
        }

    }

    class Program
    {

        static void Main(string[] args)
        {
            Automobilis auto = new Automobilis(); //objeltas
            auto.PagaminimoMetai = 2005;
            auto.Spalva = "raudona";
            Console.WriteLine(auto.PagaminimoMetai);
            Console.WriteLine(auto.Spalva);

            var auto2 = new Automobilis()
            {
                PagaminimoMetai = 2015,
                Spalva = "balta",
            };
            Console.WriteLine(auto2.PagaminimoMetai);
            Console.WriteLine(auto2.Spalva);

            var auto3 = new Automobilis(2008, "zalia", "VW", "5555", "JKO 876");

            auto3.Info();


        }
    }
}
