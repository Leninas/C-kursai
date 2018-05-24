using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_2_Delegate2
{
    class Program
    {
/*
        public delegate void Action();
        public delegate void Action<T>(T arg);

        public delegate T Func<T>();
        public delegate T Func<T, K>(K arg);
*/


        static void Add(int a, string b)
        {

        }

        static void Main(string[] args)
        {
            Photo photo = new Photo();
            Action virt = RemoveRedEye;
            Action<int, string> math = Add;

            Func<string> pavyzdys = A;
            Func<int, string> pvz = B;

            string result = pavyzdys();
            string res = pvz(1);
            /*
            int sk = 0;
            bool ats = int.TryParse("1", out sk) -- naudoti out
            if(int.TryParse("1", out sk))
            {

            }
            */
            PhotoFiltras filtras = new PhotoFiltras();
            photo.ApplyFilter(filtras.GrayScale);
            photo.ApplyFilter(RemoveRedEye);
        }

        static string A()
        {
            return "A";
        }

        static string B(int K)
        {
            return "B";
        }

        static void RemoveRedEye()
        {
            Console.WriteLine("RedEye");
        }


    }
}
