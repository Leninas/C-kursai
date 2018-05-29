using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace _24_4_daug_duomenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FromFileToSQL ffts = new FromFileToSQL();
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            string path = null;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                path = fbd.SelectedPath;
            }
            foreach (var fil in Directory.GetDirectories(path))
            {
                foreach (var file in Directory.EnumerateFiles(fil))
                {
                    ffts.Converter(file);
                }
            }
        }
    }
}
