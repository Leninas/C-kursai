using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_3_Dominiko
{
    class Veikiam
    {
        public event EventHandler VeikiamIvykis;
        public void VeikiamDabar()
        {
            Console.WriteLine("darom Kazka");
            OnVeikiamIvykis();
        }

        protected virtual void OnVeikiamIvykis()
        {
            if (VeikiamIvykis != null)
                VeikiamIvykis(this, EventArgs.Empty);
        }
    }

    class RasomIConsole
    {
        public void Rasom(object sender, EventArgs e)
        {
            Console.WriteLine("....");
        }
    }

    class RasomIFaila
    {
        public void Rasom(object sender, EventArgs e)
        {
            System.IO.StreamWriter writer = new System.IO.StreamWriter("out.txt");
            writer.WriteLine("Rasom");
            writer.Flush(); // - dar naudosim
            // writer.Close(); - jau nenaudosim
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Veikiam veikiam = new Veikiam();
            RasomIConsole rasomIConsole = new RasomIConsole();
            RasomIFaila rasomIFaila = new RasomIFaila();
            veikiam.VeikiamIvykis += rasomIConsole.Rasom;
            veikiam.VeikiamIvykis += rasomIFaila.Rasom;
            veikiam.VeikiamDabar();


        }
    }
}
