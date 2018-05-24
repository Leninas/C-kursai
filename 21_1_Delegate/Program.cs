using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_1_Delegate
{
    class Program
    {
        public delegate int MathDelegate(int a, int b);

        static int Add(int a, int b)
        {
            return (a + b);
        }
        static int Substract(int a, int b)
        {
            return (a - b);
        }


        static void Main(string[] args)
        {
            MathDelegate mathOperation = Add;
            int a = 10;
            int b = 5;
            Console.WriteLine(mathOperation(a, b));
            mathOperation += Substract;
            Console.WriteLine(mathOperation(a, b));
        }
    }
}
