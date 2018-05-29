using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static A_4.Asmenys;

namespace A_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines("Asmenys.txt");
            List<string> sarasas = new List<string>();
            Asmenys asmenys = new Asmenys();

            for (int i = 0; i < lines.Length; i++)
            {
                try
                {
                    asmenys = new Asmenys(sarasas);
                    string[] iskyrimas = lines[i].Split(' ');

                    if (int.Parse(iskyrimas[1]) < 18)
                        throw new VaikasException(iskyrimas[0], int.Parse(iskyrimas[1]));

                    if (int.Parse(iskyrimas[1]) >= 65)
                        throw new PensininkasException(iskyrimas[0], int.Parse(iskyrimas[1]));

                    else { new SuaugesException(iskyrimas[0], int.Parse(iskyrimas[1])); }

                    asmenys.Vardas.Add(lines[i]);
                }

                catch (VaikasException)
                {
                }

                catch (PensininkasException)
                {
                }
            }
        }
    }
}
