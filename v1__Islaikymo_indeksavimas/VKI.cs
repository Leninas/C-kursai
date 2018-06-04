using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v1__Islaikymo_indeksavimas
{
    class VKI
    {
        public int Id { get; set; }
        public DateTime DataNuo { get; set; }
        public DateTime DataIki { get; set; }
        public double Indeksas { get; set; }

        public VKI(int Id, DateTime DataNuo, DateTime DataIki, double Indeksas)
        {
            this.Id = Id;
            this.DataNuo = DataNuo;
            this.DataIki = DataIki;
            this.Indeksas = Indeksas;
        }

        public VKI()
        {
        }
    }
}
