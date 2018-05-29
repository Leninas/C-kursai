using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_2
{
    interface IGyvunas
    {
        string Vardas { get; set; }
        void GyvunasInfo();
    }

    class Gyvate : IGyvunas
    {
        public string Vardas { get; set; }

        public Gyvate(string Vardas)
        {
            this.Vardas = Vardas;
        }

        public Gyvate()
        {
        }

        public void GyvunasInfo()
        {
            Console.WriteLine("{0} - gyvate", Vardas);
        }
    }

    class Zuvis : IGyvunas
    {
        public string Vardas { get; set; }

        public Zuvis(string Vardas)
        {
            this.Vardas = Vardas;
        }

        public Zuvis()
        {
        }

        public void GyvunasInfo()
        {
            Console.WriteLine("{0} - zuvis", Vardas);
        }
    }

    class Paukstis : IGyvunas
    {
        public string Vardas { get; set; }

        public Paukstis(string Vardas)
        {
            this.Vardas = Vardas;
        }

        public Paukstis()
        {
        }

        public void GyvunasInfo()
        {
            Console.WriteLine("{0} - paukstis", Vardas);
        }
    }
}
