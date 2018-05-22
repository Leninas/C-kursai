using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string lines;
            System.IO.StreamReader readerr = new System.IO.StreamReader(@"C:\Users\aleni\source\repos\Programavimo_Kursai_C_sharp\WindowsFormsApp3\bin\Debug\First_1.txt");
            while ((lines = readerr.ReadLine())!=null)
            {
                comboUserID.Items.Add(lines);
            }
            readerr.Dispose();
        }

        List<Users> UsersList = new List<Users>();

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.IO.StreamReader reader = new System.IO.StreamReader(@"C:\Users\aleni\source\repos\Programavimo_Kursai_C_sharp\WindowsFormsApp3\bin\Debug\First_2.txt");
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] data = line.Split(' ');

                try
                {
                Users user = new Users(data[0], data[1], data[2],
                    // DateTime.Parse(data[3])
                    new DateTime(
                        year: int.Parse(data[3]) / 10000,
                        month: int.Parse(data[3]) % 10000 / 100,
                        day: int.Parse(data[3]) % 100
                        ), int.Parse(data[4]), int.Parse(data[5]));
                UsersList.Add(user);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            reader.Dispose(); // atlaisvina atminti

            foreach (var item in UsersList)
            {
                if (item.UserID == comboUserID.SelectedItem.ToString())
                {
                    textBox1.Text = item.UserID;
                    textBox6.Text = item.Name;
                    textBox5.Text = item.Surname;
                    textBox4.Text = item.DoB.ToShortDateString();
                    textBox3.Text = item.Salary.ToString();
                    textBox2.Text = item.WorkYear.ToString();
                }
            }
        }
    }
}
