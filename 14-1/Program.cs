using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var prieglauda = new Prieglauda("Penkta koja", "Kaimas",
                new List<Suo>
                {
                    new Suo("HavHav", "haskis", 8),
                    new Suo("Rokas", "basetas", 3),
                    new Suo("Bobik", "drathaar", 6)
                });
            prieglauda.PrieglaudaLenta();
            prieglauda.PrieglaudaAdd();
            prieglauda.PrieglaudaLenta();

        }
    }
}
