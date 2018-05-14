using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pranesimas");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tekstoLaukelis.Text);
            var sk = Convert.ToInt32(tekstoLaukelis.Text);
            MessageBox.Show(sk.ToString());
            tekstoLaukelis.Text = "";
        }

        private void perkelti_Click(object sender, EventArgs e)
        {
            var sk = Convert.ToInt32(textBox1.Text);
            var forma = new Form2(sk);
            forma.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var forma = new IvestiForma())
            {
                forma.ShowDialog();

                if (forma.DialogResult == DialogResult.OK)
                {
                    label1.Text = forma.Tekstas;
                }
            }
        }
    }
}
