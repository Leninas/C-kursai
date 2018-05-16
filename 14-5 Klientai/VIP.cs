using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_5_Klientai
{
    class VIP: Klientas
    {
        public override void SkaiciuotMoketinaSuma()
        {
            base.SkaiciuotMoketinaSuma();
            MoketinaSuma *= 0.7;
        }

        public VIP (int KlientasID, string KlientasVardas): base (KlientasID,KlientasVardas)
        {

        }
    }
}
