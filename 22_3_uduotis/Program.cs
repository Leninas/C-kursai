using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_3_uduotis
{
    class Program
    {
        public delegate void Darom(object sender, EventArgs eventArgs);
        public event Darom DaromPradzia;
        protected virtual void OnDaromPradzia()
        {
            if (DaromPradzia != null)
            {
                DaromPradzia(this, EventArgs.Empty);
                Console.WriteLine("Zinutes tekstas");
            }
        }

        public void DaromZinute()
        {
            Console.WriteLine("Zinute:");
            System.Threading.Thread.Sleep(3000);
            OnDaromPradzia();
        }

        public void OnDaromPradzia(object sender, EventArgs eventArgs)
        {
            Console.WriteLine("Messenge Service: ....");
        }

        static void Main(string[] args)
        {
            Program pradzia = new Program();
            pradzia.DaromZinute();

        }
    }
}
