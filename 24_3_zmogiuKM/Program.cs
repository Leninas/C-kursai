using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_3_zmogiuKM
{
    class Zmogus
    {
        public int Ugis { get; set; }
        public double Svoris { get; set; }
        public string Vardas { get; set; }

        public Zmogus (int Ugis, double Svoris, string Vardas)
        {
            this.Ugis = Ugis;
            this.Svoris = Svoris;
            this.Vardas = Vardas;
        }

        public double KMIskaiciavimas()
        {
            return (Svoris/Math.Pow((double)Ugis/100,2));
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            List<Zmogus> zmones = new List<Zmogus>()
            {
                new Zmogus (180, 105, "Rokas"),
                new Zmogus (170, 87, "Ignas"),
                new Zmogus (167, 50, "Darius"),
                new Zmogus (190, 96, "Rasa"),
                new Zmogus (173, 65, "Justas"),
                new Zmogus (180, 88, "Povilas"),
            };

            IEnumerable<Zmogus> KMIgeras = zmones.
                Where(x => x.KMIskaiciavimas() > 20 && x.KMIskaiciavimas() < 25).
                OrderBy(x => x.Vardas);

            //IEnumerable < Zmogus> KMIdaugiau25 =
            //    from zmogus in zmones
            //    where zmogus.KMIskaiciavimas() > 25
            //    select zmogus;

            foreach (var item in KMIgeras)
            {
                Console.WriteLine(item.Vardas);
            }
        }
    }
}
