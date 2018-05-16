using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_5_Klientai
{
    class Base: Klientas
    {
        public override void SkaiciuotMoketinaSuma()
        {
            base.SkaiciuotMoketinaSuma();
            MoketinaSuma *= 1;
        }

        public Base(int KlientasID, string KlientasVardas) : base(KlientasID, KlientasVardas)
        {

        }


    }
}
