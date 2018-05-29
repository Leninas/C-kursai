using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var kobra = new Gyvate("Kobra");
            var karpis = new Zuvis("Karpis");
            var vista = new Paukstis("Vista");
            kobra.GyvunasInfo();
            karpis.GyvunasInfo();
            vista.GyvunasInfo();
        }
    }
}
