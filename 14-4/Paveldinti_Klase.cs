using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_4
{
    class PaveldintiKlase : Alkoholis
    {
        public string Rusis { get; }
        public string KilmesSalis {get;}

        public PaveldintiKlase(double Laipsniai, int Turis, string Spalva, string Rusis)
            :base (Laipsniai,Turis,Spalva)
        {
            this.Rusis = Rusis;
        }

        public PaveldintiKlase()
        {

        }
    }
}
