﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamuProjektas_v1
{
    class Indeksas
    {
        public DateTime IndeksasNuo { get; }
        public DateTime IndeksasIki { get; }
        public double IndeksasDydis { get; }

        public Indeksas (DateTime IndeksasNuo, DateTime IndeksasIki, int IndeksasDydis)
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
            System.IO.StreamReader reader = new System.IO.StreamReader("vki.txt");

        }
    }
}
