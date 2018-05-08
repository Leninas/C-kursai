using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_2_Prekes
{
    class Parduotuves
    {
        public string Pavadinimas;
        public string Adresas;
        public int Plotas;
        public List<Preke> Prekes = new List<Preke>();

        public Parduotuves() // kad galima butu kurti nuo tuscio objekto
        {
        }

        public Parduotuves(string pavadinimas, string adresas, int plotas, List<Preke> prekes)
        {
            Pavadinimas = pavadinimas;
            Adresas = adresas;
            Plotas = plotas;
            Prekes = prekes;
        }

        public void PrekesAdd()
        {
            Console.Write("Nurodyti kiek nauju prekiu suvesti: ");
            var kiek = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < kiek; i++)
            {
                Console.WriteLine(i + 1 + "Prekes duomenys: ");
                Prekes.Add(new Preke());
            }
        }


    }


}
