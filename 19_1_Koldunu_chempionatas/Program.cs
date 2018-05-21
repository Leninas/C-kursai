using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_1_Koldunu_chempionatas
{
    class Dalyviai //<V, K, S>
    {
        //mano
        //public List<V> vienasTipas { get; set; }
        //public List<K> antrasTipas { get; set; }
        //public List<S> treciasTipas { get; set; }

        public string Vardas { get; }
        public int KiekSuvalge { get; }
        public int KiekTelpa { get; }

        public Dalyviai(string Vardas, int KiekSuvalge, int KiekTelpa)
        {
            this.Vardas = Vardas;
            this.KiekSuvalge = KiekSuvalge;
            this.KiekTelpa = KiekTelpa;
        }
    }

    class PrivalgeKoldunuExeption : Exception
    {
        public int KiekSuvalge { get; set; }
        public PrivalgeKoldunuExeption(int KiekSuvalge)
        {
            this.KiekSuvalge = KiekSuvalge;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamReader reader = new System.IO.StreamReader("koldunai.txt");
            List<Dalyviai> dalyviusarasas = new List<Dalyviai>();

            //geras !!!!!!!!!!!!!!!!!!!!!!!!!! - atvaizduoja sarasa
            //string line;
            //while ((line = reader.ReadLine()) != null)
            //{
            //    string[] data = line.Split(' ');
            //    Dalyviai dalyvis = new Dalyviai(data[0], int.Parse(data[1]), int.Parse(data[2]));
            //    dalyviusarasas.Add(dalyvis);
            //}

            //foreach (var item in dalyviusarasas)
            //{
            //    Console.WriteLine("{0} {1} {2}", item.Vardas, item.KiekSuvalge, item.KiekTelpa);
            //}



            string line;
            while ((line = reader.ReadLine()) != null)
            {
                try
                {
                    string[] data = line.Split(' ');
                    Dalyviai dalyvis = new Dalyviai(data[0], int.Parse(data[1]), int.Parse(data[2]));
                    if (dalyvis.KiekSuvalge > dalyvis.KiekTelpa)
                        throw new PrivalgeKoldunuExeption(dalyvis.KiekSuvalge);
                    dalyviusarasas.Add(dalyvis);
                }
                catch (PrivalgeKoldunuExeption ex)
                {
                    Console.WriteLine("PERSIVALGE");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Nezinoma klaida");
                }

            }

            int max = int.MinValue;
            Dalyviai maxDalyvis = new Dalyviai(null, 0, 0);
            foreach (var item in dalyviusarasas)
            {
                if (item.KiekSuvalge > max)
                {
                    max = item.KiekSuvalge;
                    maxDalyvis = item;
                }
            }
            Console.WriteLine("Laimejo {0}, suvalges {1}", maxDalyvis.Vardas, maxDalyvis.KiekSuvalge);
        }




        //buvo mano pradzia
        //List<Dalyviai<string, int, int>> sarasas = new List<Dalyviai<string, int, int>>();
        //Console.WriteLine(Dalyviai[0]);



        //string line;
        //while ((line = reader.ReadLine()) != null)
        //{
        //    string[] data = line.Split(' ');
        //    List<int> tempData = new List<int>();
        //    foreach (var item in data)
        //    {
        //        tempData.Add(int.Parse(item));
        //    }
        //    sarasas.Add(tempData);
        //}
    }
}
