using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_darbas
{
    public partial class Form3 : Form
    {
        public List<Skolininkas> Skolininkai { get; }

        public Form3()
        {
            InitializeComponent();
            Skolininkai = new List<Skolininkas>();

            var kelias = @"C:\Users\aleni\Desktop\C mokymai\skolininkai.csv";
            var tekstas = File.ReadAllLines(kelias);

            foreach (var eilute in tekstas)
            {
                Skolininkai.Add(new Skolininkas(eilute));
            }
            dataGridView1.DataSource = Skolininkai;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
