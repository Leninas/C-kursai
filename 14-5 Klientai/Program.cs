using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_5_Klientai
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Klientas> clients = new List<Klientas>
            {
                new VIP (1, "Jurgis Jurgaitis"),
                new Silver (2, "Nikolajus Pupkinas"),
                new Base (3, "Darius Petraitis"),
            };

            foreach (var item in clients)
            {
                item.SkaiciuotMoketinaSuma();
                Console.WriteLine(item.KlientasVradas + " reikia moketi " + item.MoketinaSuma);
            }
        }
    }
}
