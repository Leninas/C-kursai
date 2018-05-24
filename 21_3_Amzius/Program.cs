using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_3_Amzius
{
    public class Asmenys
    {
        public string Vardas { get; set; }
        public int Amzius { get; set; }

        public void AmziausGrupe(Action<string, int> NustatymasAction)
        {
            NustatymasAction(Vardas, Amzius);
        }

        public Asmenys(string Vardas, int Amzius)
        {
            this.Vardas = Vardas;
            this.Amzius = Amzius;
        }

    }

    class Program
    {


        static void Main(string[] args)
        {
            Action<string, int> sarasasMetodu = TikrinaVaika;
            sarasasMetodu += TikrinaSeni;
            sarasasMetodu += TikrinaSuaugusi;

            List<Asmenys> asmenys = new List<Asmenys>
            {
                new Asmenys ("Danguuole", 54),
                new Asmenys ("Jonas", 75),
                new Asmenys ("Rokas", 12),
                new Asmenys ("Svetlana", 34),
                new Asmenys ("Jokubas", 19),
            };

            foreach (var item in asmenys)
            {
                item.AmziausGrupe(sarasasMetodu);
            }
        }

        static void TikrinaVaika(string Vardas, int Amzius)
        {
            if (Amzius < 18)
            {
                Console.WriteLine("{0} - vaikas", Vardas);
            }
        }

        static void TikrinaSeni(string Vardas, int Amzius)
        {
            if (Amzius >= 65)
            {
                Console.WriteLine("{0} - vaikas", Vardas);
            }
        }

        static void TikrinaSuaugusi(string Vardas, int Amzius)
        {
            if (Amzius < 65 && Amzius >= 18)
            {
                Console.WriteLine("{0} - suauges", Vardas);
            }
        }
    }
}
