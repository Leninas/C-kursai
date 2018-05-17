using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_4_Uzduotis_Interface_FileWrite
{
    class Darbuotojas: Darbas
    {
        public int ID { get; }
        public string Vardas { get; }

        [STAThread]
        public void PrintOutData()
        {
            // iskvies langa, kuriame bus saugomi failai
            FolderBrowserDialog fdb = new FolderBrowserDialog();
            string path = null;
            if(fdb.ShowDialog() == DialogResult.OK)
            {
                path = fdb.SelectedPath;
            }
            System.IO.StreamWriter writer = new System.IO.StreamWriter(path+@"\failas.csv", true); // - true reiskia kad papildo failo info
            writer.WriteLine(ID + ' ' + Vardas);
            writer.Flush(); // - Flush isvalo buferi
        }

        public Darbuotojas(int ID, string Vardas)
        {
            this.ID = ID;
            this.Vardas = Vardas;
        }
    }

    public interface Darbas
    {
        int ID { get; }
        string Vardas { get; }
        void PrintOutData();
    }
}
