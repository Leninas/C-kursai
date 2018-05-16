using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_6_Abstrakcios_klases
{
    abstract class Figura
    {
        public abstract double Plotas();
    }

    class Trikampis: Figura
    {
        public int A { get; set; }
        public int B { get; set; }

        public override double Plotas()
        {
            return (A * B * 0.5);
        }
    }

    class Apskritimas: Figura
    {
        public int r { get; set; }

        public override double Plotas()
        {
            return (Math.PI * Math.Pow(r, 2));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Figura fig = new Apskritimas();
        }
    }
}
