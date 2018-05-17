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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var vardasNew = textBox1.Text;
            var pavardeNew = textBox2.Text;

            //using (StreamWriter sw = new StreamWriter(@"C:\Users\aleni\Desktop\C mokymai\skolininkai.csv", append: true))
            //{
            //    sw.WriteLine(vardasNew.InnerText.Trim());
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
