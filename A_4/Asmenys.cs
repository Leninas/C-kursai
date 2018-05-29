using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_4
{
    public class Asmenys
    {
        public List<string> Vardas { get; set; }

        public Asmenys(List<string> Vardas)
        {
            this.Vardas = Vardas;
        }

        public Asmenys()
        {
        }

        public class VaikasException : Exception
        {
            public string Vardas { get; set; }
            public int Amzius { get; set; }
            public VaikasException(string Vardas, int Amzius)
            {
                this.Vardas = Vardas;
                this.Amzius = Amzius;
                Console.WriteLine("{0}\t{1} m. - vaikas", Vardas, Amzius);
            }
        }

        public class PensininkasException : Exception
        {
            public string Vardas { get; set; }
            public int Amzius { get; set; }
            public PensininkasException(string Vardas, int Amzius)
            {
                this.Vardas = Vardas;
                this.Amzius = Amzius;
                Console.WriteLine("{0}\t{1} m. - pensininkas", Vardas, Amzius);
            }

        }

        public class SuaugesException : Exception
        {
            public string Vardas { get; set; }
            public int Amzius { get; set; }
            public SuaugesException(string Vardas, int Amzius)
            {
                this.Vardas = Vardas;
                this.Amzius = Amzius;
                Console.WriteLine("{0}\t{1} m.", Vardas, Amzius);
            }
        }
    }
}
