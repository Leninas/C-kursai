using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_2_Delegate2
{
    class PhotoFiltras
    {
        public string  Name { get; set; }

        public void GrayScale()
        {
            Console.WriteLine("GS");
        }

        public void Sepia()
        {
            Console.WriteLine("Sepia");
        }

        public PhotoFiltras()
        {

        }
    }
}
