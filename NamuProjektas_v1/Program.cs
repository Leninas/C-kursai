using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamuProjektas_v1
{
    class Indeksas
    {
        public DateTime IndeksasNuo { get; set;  }
        public DateTime IndeksasIki { get; set;  }
        public double IndeksasDydis { get; set; }

        public Indeksas (DateTime IndeksasNuo, DateTime IndeksasIki, double IndeksasDydis)
        {
            this.IndeksasNuo = IndeksasNuo;
            this.IndeksasIki = IndeksasIki;
            this.IndeksasDydis = IndeksasDydis;
            // DateTime date = new dateTime(year:1992 ,month: 03, day:03 )
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //System.IO.StreamReader reader = new System.IO.StreamReader("vki.txt");

            List<Indeksas> vki = new List<Indeksas>()
            {
                new Indeksas (new DateTime(year: 2012, month: 02, day: 01), new DateTime(year: 2013, month: 01, day: 31), 146,4),
                new Indeksas (2012.02.01, 2013.01.31, 146,4),
            };

        }
    }
}
