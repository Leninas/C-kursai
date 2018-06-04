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
using System.Data.Linq;

namespace _24_4_daug_duomenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DataContext db = new DataContext(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\aleni\source\repos\Programavimo_Kursai_C_sharp\24_4_daug_duomenu\DataBig.mdf;Integrated Security=True");
            Table<Sensor> sensor = db.GetTable<Sensor>();
            foreach (var item in sensor)
            {
                comboSN.Items.Add(item.Id);
            }
            chart1.Series.Add("Min");
            chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series.Add("Max");
            chart1.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

        }

        private void dataToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
                    try
                    {
                        ffts.Converter(file);
                    }

                    catch (Exception)
                    {

                    }
                }
            }
        }

        private void comboSN_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear(); // isvalo grida pries atsinaujinant duomenims
            DataContext db = new DataContext(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\aleni\source\repos\Programavimo_Kursai_C_sharp\24_4_daug_duomenu\DataBig.mdf;Integrated Security=True");
            var measurement = db.GetTable<Measurement>().Where(x => x.SN.ToString() == comboSN.SelectedItem.ToString());

            List<decimal?> xValues = new List<decimal?>();
            List<decimal?> yVout = new List<decimal?>();
            List<decimal?> yMin = new List<decimal?>();
            List<decimal?> yMax = new List<decimal?>();


            foreach (var item in measurement)
            {
                dataGridView1.Rows.Add(item.Position, item.Vout, item.Min, item.Max);

                xValues.Add(item.Position);
                yVout.Add(item.Vout);
                yMin.Add(item.Min);
                yMax.Add(item.Max);
            }
            chart1.Series[0].Points.DataBindXY(xValues, yVout);
            chart1.Series[1].Points.DataBindXY(xValues, yMin);
            chart1.Series[2].Points.DataBindXY(xValues, yMax);
        }
    }
}
