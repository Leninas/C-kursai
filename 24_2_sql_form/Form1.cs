using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_2_sql_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void studentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kCSDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kCSDataSet.Student_address' table. You can move, or remove it, as needed.
            this.student_addressTableAdapter.Fill(this.kCSDataSet.Student_address);
            // TODO: This line of code loads data into the 'kCSDataSet.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.kCSDataSet.Students);

        }

        private void resetToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.studentsTableAdapter.Reset(this.kCSDataSet.Students);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
