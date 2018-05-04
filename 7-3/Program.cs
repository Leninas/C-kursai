using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var val = 8;
            Console.Write("Darbo valandu per diena:\n"+val+"\n");
            Console.WriteLine("Iskepama kepalu per valanda (nurodyti):");
            var kep = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Yra darbuotoju kepykloje (nurodyti):");
            var darb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vieno kepalo savikaina (nurodyti):");
            var savik = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Vieno kepalo pardavimo kaina (nurodyti):");
            var kaina = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Yra uzsakymu per diena (nurodyti):");
            var uzs = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            var kepviso = val * kep * darb;
            Console.WriteLine("Per diena viso iskepama kepalu:"+kepviso);
            var kepsavik = kepviso * savik;
            var pajamos = kepviso * kaina;
            var pelnas = pajamos - kepsavik;
            Console.WriteLine("Visu kepalu savikaina: "+ kepsavik+", pajamos pardavus: "+ pajamos + ", gauto pelno dalis: "+pelnas);

            if (kepviso>=uzs)
            {
                Console.WriteLine("Kepykla spes iskepti visus tos dienos uzsakymus.");
            }
            else
            {
                Console.WriteLine("Kepykla nespes iskepti" + (uzs - kepviso) + " kepalu.");
            }
        }
    }
}
