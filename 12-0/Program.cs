using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sk = new List<int>();
            sk.Add(3);
            sk.Add(5);

            foreach (var skone in sk)
            {
                Console.WriteLine(skone);
            }
        }
    }
}
