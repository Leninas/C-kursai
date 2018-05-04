using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var metodas = new Program(); // objektas
            var vardas = metodas.VardasMetod();
            int amz = metodas.AmziusMetod();
            metodas.VardasEkranas(vardas);
            metodas.AmziusEkranas(amz);
            metodas.SkEkranas();
            var skList = metodas.ListMetod();
            foreach (var skone1 in skList)
            {
                Console.Write(skone1);
            }
            var ListSuma = metodas.ListSuma(skList);

        }

        public string VardasMetod()
        {
            Console.WriteLine("Nurodyti varda: ");
            var vardas = Console.ReadLine();
            return vardas;
        }

        public void VardasEkranas(string vardas)
        {
            Console.WriteLine(" Rodo " + vardas);
        }

        public int AmziusMetod()
        {
            Console.WriteLine("Nurodyti amziu ");
            var amz = Convert.ToInt32(Console.ReadLine());
            return amz;
        }

        public void AmziusEkranas(int amz)
        {
            Console.WriteLine(" Rodo " + amz);
        }


        public void SkEkranas()
        {
            Console.WriteLine("Nurodykite skaiciu1:");
            var sk1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nurodykite skaiciu2:");
            var sk2 = Convert.ToInt32(Console.ReadLine());
            int sk = SkMetod(sk1, sk2);
            Console.WriteLine("Suma:" + sk);
        }

        public int SkMetod(int a, int b)
        {
            return a + b;
        }

        
        public List<int> ListMetod()
        {
            List<int> sk = new List<int>();

            for (int i = 0; i <= 3; i++)
            {
                var li = Convert.ToInt32(Console.ReadLine());
                sk.Add(li);
            }
            return sk;
        }

        public int ListSuma(List<int> sarasas)
        {
            var sum = sarasas.Sum();
            return sum;
        }

    }
}
