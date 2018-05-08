using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_2_Prekes
{
    class Preke
    {
        public string Pavadinimas;
        public double Savikaina;
        public double Kaina;
        public int Kiekis;

        public Preke(string pavadinimas, double savikaina, double kaina, int kiekis)
        {
            Pavadinimas = pavadinimas;
            Savikaina = savikaina;
            Kaina = kaina;
            Kiekis = kiekis;
        }

        public Preke() // prekiu suvedimui
        {
            Console.Write("Prekes pavadinimas: ");
            Pavadinimas = Console.ReadLine();
            Console.Write("Prekes savikaina: ");
            Savikaina = Convert.ToDouble(Console.ReadLine());
            Console.Write("Prekes kaina: ");
            Kaina = Convert.ToDouble(Console.ReadLine());
            Console.Write("Prekes kiekis: ");
            Kiekis = Convert.ToInt32(Console.ReadLine());
        }

        public double PrekePelnas()
        {
            var pelnas = (Kaina - Savikaina)*Kiekis;
            return pelnas;
        }

        public string PrekeLikutis()
        {
            var likutis = "";
            if (Kiekis >= 5)
            {
                likutis = " (mazas kiekis)";
            }
            return likutis;
        }

        public void PrekeInfo()
        {
            Console.Write("Preke: {0}, savikaina - {1}, kaina - {2}, kiekis - {3}{4}, pelnas - {5}", Pavadinimas, Savikaina, Kaina, Kiekis, PrekeLikutis(), PrekePelnas());
        }


    }
}
