using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_3_Kompas
{
    class Kompiuteris
    {
        public string Vaizduske { get; private set; }
        public string Motinine { get; private set; }
        public int DiskoTalpa { get; private set; }

        public Kompiuteris(string vaizduske, string motinine, int diskoTalpa)
        {
            Vaizduske = vaizduske;
            Motinine = motinine;
            DiskoTalpa = diskoTalpa;
        }

        public Kompiuteris()
        {

        }

        //ivedimo isvedimo metodai

        public void Ivedimas() // prekiu suvedimui
        {
            Console.Write("Vaizduskes pavadinimas: ");
            Vaizduske = Console.ReadLine();
            Console.Write("Motinines pavadinimas: ");
            Motinine = Console.ReadLine();
            Console.Write("Disko talpa: ");
            DiskoTalpa = Convert.ToInt32(Console.ReadLine());
        }
    }
}
