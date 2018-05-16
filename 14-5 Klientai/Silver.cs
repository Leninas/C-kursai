using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_5_Klientai
{
    class Silver: Klientas
    {
        public override void SkaiciuotMoketinaSuma()
        {
            base.SkaiciuotMoketinaSuma();
            MoketinaSuma *= 0.9;
        }

        public Silver(int KlientasID, string KlientasVardas): base(KlientasID, KlientasVardas)
        {

        }

    }
}
