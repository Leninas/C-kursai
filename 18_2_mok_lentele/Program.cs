using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_2_mok_lentele
{

    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamReader reader = new System.IO.StreamReader("vidurkiai.txt");
            List<List<int>> sarasas = new List<List<int>>();
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] data = line.Split(' ');
                List<int> tempData = new List<int>();
                foreach (var item in data)
                {
                    tempData.Add(int.Parse(item));
                }
                sarasas.Add(tempData);
            }
            foreach (var item in sarasas)
            {
                Console.WriteLine("Mokinio vidurkis yra {0:0.00}", item.Average());
            }

            var laikinaKopija = sarasas.ToArray();
            for (int i = 0; i < laikinaKopija[0].Count; i++)
            {
                int suma = 0;
                int divider = 0;
                for (int j = 0; j < laikinaKopija.Length; j++)
                {
                    if (laikinaKopija[j].Count > i)
                        suma += laikinaKopija[j].ElementAt(i);
                    else
                        divider = j;

                    if(laikinaKopija.Length-1 >= j)
                    {
                        divider = laikinaKopija.Length;
                    }
                }
                Console.WriteLine("darbu vidurkis yra {0:0.00}", ((double)suma / divider));
            }

            List<List<int>> surikiuotaInformacija = new List<List<int>>();
            while (sarasas.Count != 0)
            {
                double max = int.MinValue;
                List<int> maxMember = new List<int>();
                foreach (var item in sarasas)
                {
                    if (max < item.Average())
                    {
                        max = item.Average();
                        maxMember = item;
                    }
                }
                surikiuotaInformacija.Add(maxMember);
                sarasas.Remove(maxMember);
            }
            foreach (var item in surikiuotaInformacija)
            {
                Console.WriteLine("Mokinio vidurkis {0}", item.Average());
            }
        }
    }
}
