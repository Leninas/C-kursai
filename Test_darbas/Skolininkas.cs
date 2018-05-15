using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_darbas
{
    public class Skolininkas
    {
        public string Vardas { get; private set; }
        public string Pavarde { get; private set; }

        public Skolininkas(string vardas, string pavarde)
        {
            Vardas = vardas;
            Pavarde = pavarde;
        }

        public Skolininkas()
        {

        }

        public Skolininkas(string eilute)
        {
            var asmuo = eilute.Split(';');
            Vardas = asmuo[0];
            Pavarde = asmuo[1];
        }

        public void SkolininkasIvesti() // Skolininko duomenims suvesti
        {
            Console.Write("Skolininko vardas: ");
            Vardas = Console.ReadLine();
            Console.Write("Skolininko pavardė: ");
            Pavarde = Console.ReadLine();
        }

        public void SkolininkasInfo() // Skolininko duomenims atvaizduoti
        {
            Console.Write("{0} {1}", Vardas, Pavarde);
        }





    }
}
