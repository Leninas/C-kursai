using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_2_Interface_testing
{
    public class Siuntimas: ISiuntimas
    {
        public bool IsShipped { get; }
        public int SiuntosSkaiciutuvas()
        {
            if (IsShipped == false)
                throw new Exception(message: "Siunta jau issiusta");
            return 50;
        }
        public Siuntimas(bool IsShipped)
        {
            this.IsShipped = IsShipped;
        }
    }

    public interface ISiuntimas
    {
        bool IsShipped { get; }
        int SiuntosSkaiciutuvas();
    }

    public class Uzsakymas
    {
        public int Kaina { get; set; }
        public ISiuntimas Siunta { get; set; }
        public string Clienta { get; set; }

        public void ProcessOrder()
        {
            Kaina = Siunta.SiuntosSkaiciutuvas() + 20;
        }

        public Uzsakymas(ISiuntimas Siunta)
        {
            this.Siunta = Siunta;
        }
    }
}
