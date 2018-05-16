using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kortu_kalade
{



    class Korta
    {
        public string Skaicius { get; }
        public char Zenklai { get; }

        //be zemiau nurodyto metodo galimas masyvas
        private string SkaiciausKeitimasRaide (string Skaicius)
        {
            switch (Skaicius)
            {
                case "1":
                    return "A";
                case "11":
                    return "J";
                case "12":
                    return "Q";
                case "13":
                    return "K";

                default:
                    return Skaicius;
            }
        }

        public Korta(string Skaicius, char Zenklai)
        {
        this.Skaicius = SkaiciausKeitimasRaide(Skaicius);
        this.Zenklai = Zenklai;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            char[] raides = { 'K', 'S', 'P', 'B' };
            int i = 0;
            List<Korta> kalade = new List<Korta>();

            while (i < 52)
            {
                Korta laikinaKorta = new Korta(rng.Next(1, 14).ToString(), raides[rng.Next(0, raides.Length)]);

                bool pozymis = true;

                foreach (var item in kalade)
                {
                    if(laikinaKorta.Skaicius == item.Skaicius && laikinaKorta.Zenklai == item.Zenklai)
                    {
                        pozymis = false;
                        break;
                    }
                }
                if (pozymis)
                {
                    kalade.Add(laikinaKorta);
                    i++;
                }
            }
            foreach (var item in kalade)
            {
                Console.WriteLine(item.Zenklai + " " + item.Skaicius);
            }

        }
    }
}
