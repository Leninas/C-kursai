using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamuProjektas_v1
{
    class VartotojuKoduIndeksai<T,K,A>
    {
        public List<T> vienasTipas { get; set; }
        public List<T> antrasTipas { get; set; }
        public List<T> treciasTipas { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<VartotojuKoduIndeksai<int, string, char>> kazkas = new List<VartotojuKoduIndeksai<int, string, char>>();
        }
    }
}
