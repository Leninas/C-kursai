using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22_2_Event_random
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += MetaMessageMox;
            textBox1.Click += textBox1_Click;
        }

        private void MetaMessageMox(object sender, EventArgs eventArgs)
        {
            MessageBox.Show("Issoko langas");
        }

        private void textBox1_Click(object sender, EventArgs eventArgs)
        {
            button1.Enabled = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Labas";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
