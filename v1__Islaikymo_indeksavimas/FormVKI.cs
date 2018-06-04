using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v1__Islaikymo_indeksavimas
{
    public partial class FormVKI : Form
    {
        public FormVKI()
        {
            InitializeComponent();
        }

        private void FormVKI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vKIDataSet.VKI' table. You can move, or remove it, as needed.
            this.vKITableAdapter.Fill(this.vKIDataSet.VKI);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
