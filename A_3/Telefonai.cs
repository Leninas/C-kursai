using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_3
{
    class Telefonai
    {
        public List<string> Vardas { get; set; }
        public List<string> Pavarde { get; set; }
        public List<string> Numeris { get; set; }

        public Telefonai(List<string> Vardas, List<string> Pavarde, List<string> Numeris)
        {
            this.Vardas = Vardas;
            this.Pavarde = Pavarde;
            this.Numeris = Numeris;
        }

        public Telefonai()
        {
        }
    }
}
