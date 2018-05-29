using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_5
{
    class Adresatai
    {
        public delegate void DovanosParenkamDelegate();

        public List<string> AdresataiSarasas { get; set; }

        public Adresatai(List<string> AdresataiSarasas)
        {
            this.AdresataiSarasas = AdresataiSarasas;
        }

        public Adresatai()
        {
        }

        //Priskirti dovanas adresatui
        public void PridetiDovana(DovanosParenkamDelegate dovana)
        {
            foreach (var item in AdresataiSarasas)
            {
                Console.Write("Adresatas {0} - dovana ", item);
                dovana();
            }
        }
    }

    class Dovanos
    {
        public void Puodelis()
        {
            Console.WriteLine("Puodelis");
        }

        public void Zenkliukas()
        {
            Console.WriteLine("Zenkliukas");
        }

        public void Tusinukas()
        {
            Console.WriteLine("Tusinukas");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nurodykyte dovanoms skirta biudzeta:");
            int biudzetas = int.Parse(Console.ReadLine());

            Adresatai adresatai = new Adresatai(System.IO.File.ReadAllLines("Adresatai.txt").ToList<string>());
            Dovanos dovana = new Dovanos();

            if (biudzetas - 10 * adresatai.AdresataiSarasas.Count > 1500)
            {
                adresatai.PridetiDovana(dovana.Puodelis);
            }

            else if (biudzetas - 10 * adresatai.AdresataiSarasas.Count < 1500 && biudzetas - 10 * adresatai.AdresataiSarasas.Count > 500)
            {
                adresatai.PridetiDovana(dovana.Zenkliukas);
            }

            else
                adresatai.PridetiDovana(dovana.Tusinukas);
        }
    }
}
