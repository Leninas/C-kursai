using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_3_pvz
{
    class VartotojuKoduIndeksai1<T, K, A>
    {
        public List<T> vienasTipas { get; set; }
        public List<T> antrasTipas { get; set; }
        public List<T> treciasTipas { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<VartotojuKoduIndeksai1<int, string, char>> kazkas = new List<VartotojuKoduIndeksai1<int, string, char>>();
        }
    }
}
