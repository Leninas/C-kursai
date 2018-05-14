using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_2_su_failu
{
    public class Auto
    {
        // propg - greitas surasymas
        public string Marke { get; private set; }
        public string Modelis { get; private set; }
        public int Metai { get; private set; }

        // ctorp - greitas surasymas
        //public Auto()
        //{
        //    Marke = marke;
        //    Modelis = Modelis;
        //    Metai = Metai;
        //}

        public Auto(string eilute)
        {
            var duomenys = eilute.Split(';');
            Marke = duomenys[0];
            Modelis = duomenys[1];
            Metai = Convert.ToInt32(duomenys[2]);
        }
    }
}
