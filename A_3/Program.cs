using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            string[] Name = System.IO.File.ReadAllLines("Name.txt");
            string[] Surname = System.IO.File.ReadAllLines("Surname.txt");

            Console.WriteLine("Nurodykite kontaktu skaiciu telefonu knygoje:");

            int kontaktai = int.Parse(Console.ReadLine());

            List<string> NameK = new List<string> { };
            List<string> SurnameK = new List<string> { };
            List<string> Number = new List<string> { };
            string num = "+370";

            for (int i = 0; i < kontaktai; i++)
            {
                NameK.Add(Name[rng.Next(Name.Length)]);
                SurnameK.Add(Surname[rng.Next(Surname.Length)]);

                for (int k = 0; k < 6; k++)
                {
                    num += rng.Next(0, 8);
                }
                Number.Add(num);
                num = "+370";
            }

            //Knygos sukurimas:
            var TelefonuKnyga = new Telefonai(NameK, SurnameK, Number);

            //Knygos atvaizdavimas:
            for (int i = 0; i < TelefonuKnyga.Vardas.Count; i++)
            {
                Console.WriteLine("{0} {1} {2}", TelefonuKnyga.Vardas[i], TelefonuKnyga.Pavarde[i], TelefonuKnyga.Numeris[i]);
            }
        }
    }
}
