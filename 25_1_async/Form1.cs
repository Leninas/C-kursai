using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25_1_async
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_ClickAsync(object sender, EventArgs e)
        {
            await DoStuff();
        }

        private async Task DoStuff()
        {
            System.Threading.Thread.Sleep(60000);
            MessageBox.Show("Laikas praejo");
            //return null;
        }
    }
}
