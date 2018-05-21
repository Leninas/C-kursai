using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamuProjektas_v1
{
    class VKI<D1,D2,I>
    {
        public List<D1> vienasTipas { get; set; }
        public List<D2> antrasTipas { get; set; }
        public List<I> treciasTipas { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamReader reader = new System.IO.StreamReader("vki.txt");

            List<VKI<int, string, char>> kazkas = new List<VKI<int, string, char>>();
        }
    }
}
