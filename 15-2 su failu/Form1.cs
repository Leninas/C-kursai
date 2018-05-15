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

namespace _15_2_su_failu
{
    public partial class Form1 : Form
    {
        //propg
        public List<Auto> Automobiliai { get; }


        public Form1()
        {
            InitializeComponent();
            Automobiliai = new List<Auto>();
        }

        private void iseitiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void atidarytiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var failas = new OpenFileDialog())
            {
                failas.Filter = "csv failas (*.csv)|*.csv";
                failas.InitialDirectory = @"C:\Users\aleni\Desktop\C mokymai";

                // - tesioginis kelias iki failo:
                //var kelias = @"C:\Users\aleni\Desktop\C mokymai\automobilis.csv";
                //var tekstas = File.ReadAllLines(kelias);


                //failas.ShowDialog();
                // MessageBox.Show(failas.FileName); - atidaryti forma ieskoti faila kompe

                if (failas.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        //File.ReadAllLine Method:
                        var tekstas = File.ReadAllLines(failas.FileName);

                        foreach (var eilute in tekstas)
                        {
                            //MessageBox.Show(eilute);
                            //var automoto = new Auto(eilute);
                            //Automobiliai.Add(automoto);
                            Automobiliai.Add(new Auto(eilute));
                        }
                        dataGridView1.DataSource = Automobiliai;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                    }
                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
