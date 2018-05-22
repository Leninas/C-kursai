using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alimentai
{
    class Indeksai
    {
        public DateTime IndeksasNuo { get; }
        public DateTime IndeksasIki { get; }
        public double IndeksasDydis { get; }

        public Indeksai (DateTime IndeksasNuo, DateTime IndeksasIki, int IndeksasDydis)
        {
            this.IndeksasNuo = IndeksasNuo;
            this.IndeksasIki = IndeksasIki;
            this.IndeksasDydis = IndeksasDydis;
        }
    }
}
