using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_5_Klientai
{
    class Klientas
    {
        public int KlientasID { get; }
        public string KlientasVradas { get; set; }
        public double MoketinaSuma { get; protected set; }

        public Klientas (int KlientasID, string KlientasVardas)
        {
            this.KlientasID = KlientasID;
            this.KlientasVradas = KlientasVardas;
        }

        public virtual void SkaiciuotMoketinaSuma()
        {
            MoketinaSuma = 10 * 1;
        }
    }
}
