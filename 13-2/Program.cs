using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //var balai2017 = new Dictionary<sting, int>();
            Program programa = new Program();
            var balai2016 = programa.Ivedimas();
            var balai2017 = programa.Ivedimas();

            programa.Isviedimas(balai2016);
            programa.Isviedimas(balai2017);
            programa.Palyginti(balai2016, balai2017);
        }

        public int minbalas(Dictionary<string, int> balai)
        {
            var indeksas = 0;
            var maziausias = balai.ElementAt(0).Value; //balas[0] reiksme

            for (int i = 0; i < balai.Count; i++)
            {
                if (balai.ElementAt(i).Value < maziausias)
                {
                    indeksas = i;
                    maziausias = balai.ElementAt(i).Value;
                }
            }
            return indeksas;
        }


        public int maxbalas(Dictionary<string, int> balai)
        {
            var indeksas = 0;
            var max = balai.ElementAt(0).Value; //balas[0] reiksme

            for (int i = 0; i < balai.Count; i++)
            {
                if (balai.ElementAt(i).Value > max)
                {
                    indeksas = i;
                    max = balai.ElementAt(i).Value;
                }
            }
            return indeksas;
        }

        public double Vidurkis(Dictionary<string, int> balai)
        {
            var suma = 0;
            foreach (var balas in balai)
            {
                suma += balas.Value;
            }
            var kiekis = balai.Count();
            return (double)suma / kiekis;
        }

        public void Palyginti(Dictionary<string, int> balai1, Dictionary<string, int> balai2)
        {
            var vidurk1 = Vidurkis(balai1);
            var vidurk2 = Vidurkis(balai2);
            if (vidurk1 > vidurk2)
            {
                Console.WriteLine("2016 vidurkis didesnis");
            }
            else if (vidurk2 == vidurk1)
            {
                Console.WriteLine("2016 ir 2017 vidurkis vienodas");
            }
            else
            {
                Console.WriteLine("2017 vidurkis didesnis");
            }
        }


        public int Suma(Dictionary<string, int> balai)
        {
            var suma = 0;
            foreach (var balas in balai)
            {
                suma += balas.Value;
            }
            return suma;
        }

        public void Isviedimas(Dictionary<string, int> balai)
        {
            foreach (var balas in balai)
            {
                Console.WriteLine(balas.Key + " - " + balas.Value);
            }
            Console.WriteLine();
            Console.WriteLine("balu suma: " + Suma(balai));
            Console.WriteLine("maziausias balas: " + balai.ElementAt(minbalas(balai)).Value);
            Console.WriteLine("didziausias balas: " + balai.ElementAt(maxbalas(balai)).Value);
            Console.WriteLine("Vidurkis: " + Vidurkis(balai));
            Console.WriteLine();
        }

        public Dictionary<string, int> Ivedimas()
        {
            var balai = new Dictionary<string, int>();

            Console.WriteLine("Kiek duomenu suvesite? ");
            var kiek = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < kiek; i++)
            {
                Console.WriteLine("Salies pavadinimas: ");
                var pavad = Console.ReadLine();
                Console.WriteLine("Balai: ");
                var gautibalai = Convert.ToInt32(Console.ReadLine());
                balai.Add(pavad, gautibalai);

            }
            return balai;
        }



    }
}