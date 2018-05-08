using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_1
{
    class Prieglauda
    {
        public string Pavadinimas;
        public string Adresas;
        public List<Suo> Sunys;
        // g.b. public List<Suo> Sunys = new List<Suo>();

        public Prieglauda(string pavadinimas, string adresas)
        {
            Pavadinimas = pavadinimas;
            Adresas = adresas;
            Sunys = new List<Suo>();
        }

        public Prieglauda(string pavadinimas, string adresas, List<Suo> sunys)
        {
            Pavadinimas = pavadinimas;
            Adresas = adresas;
            Sunys = sunys;
        }

        public void PrieglaudaLenta()
        {
            Console.WriteLine(Pavadinimas + ", " + Adresas);
            foreach (var suo in Sunys)
            {
                suo.SuoInfo();
            }
            Console.WriteLine("Vyriasias suo:");
            VyrSuo().SuoInfo();
            Console.WriteLine("Jauniausias suo:");
            JaunSuo().SuoInfo();

        }

        public void PrieglaudaAdd()
        {
            Console.WriteLine("Kiek nauju sunu prideti?");
            var kiek = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < kiek; i++)
            {
                Console.WriteLine(i+1 + " suns duomenys:");
                Sunys.Add(new Suo());
            }
        }

        public Suo VyrSuo()
        {
            var vyr = Sunys.First();
            foreach (var suo in Sunys)
            {
                if (suo.Amzius > vyr.Amzius)
                {
                    vyr = suo;
                }
            }
            return vyr;
        }

        public Suo JaunSuo()
        {
            var jaun = Sunys.First();
            foreach (var suo in Sunys)
            {
                if (suo.Amzius < jaun.Amzius)
                {
                    jaun = suo;
                }
            }
            return jaun;
        }

        // -toliau nezinau ar gerai
        //public void Info()
        //{
        //    Console.WriteLine("Auto {2}, gam. {0}, spalva - {1}, vin - {3}, v/n {4}", PagaminimoMetai, Spalva, Marke, VIN, ValstybinisNumeris);
        //}


    }
}
