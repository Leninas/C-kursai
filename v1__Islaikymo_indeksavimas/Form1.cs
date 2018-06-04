using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Linq;



namespace v1__Islaikymo_indeksavimas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var formaVKI = new FormVKI();
            formaVKI.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // - list
            //
            List<VKI> vki = new List<VKI>()
            {
                new VKI (1, DateTime.Parse("2008-02-01"), DateTime.Parse("2009-01-31"), 108.1),
                new VKI (2, DateTime.Parse("2009-02-01"), DateTime.Parse("2010-01-31"), 108.5),
                new VKI (3, DateTime.Parse("2010-02-01"), DateTime.Parse("2011-01-31"), 101.3),
                new VKI (4, DateTime.Parse("2011-02-01"), DateTime.Parse("2012-01-31"), 103.8),
                new VKI (5, DateTime.Parse("2012-02-01"), DateTime.Parse("2013-01-31"), 103.4),
                new VKI (6, DateTime.Parse("2013-02-01"), DateTime.Parse("2014-01-31"), 103.4),
                new VKI (7, DateTime.Parse("2014-02-01"), DateTime.Parse("2015-01-31"), 102.8),
                new VKI (8, DateTime.Parse("2015-02-01"), DateTime.Parse("2016-01-31"), 100.4),
                new VKI (9, DateTime.Parse("2016-02-01"), DateTime.Parse("2017-01-31"), 99.9),
                new VKI (10, DateTime.Parse("2017-02-01"), DateTime.Parse("2018-01-31"), 101.7),
                new VKI (11, DateTime.Parse("2018-02-01"), DateTime.Parse("2019-01-31"), 103.9),
            };

            // ----------------------------------- trinti
            //piDataNuo.Text = "2015-03-15";
            //piDataIki.Text = "2018-03-15";
            //piDydis.Text = Convert.ToString("100");
            // --------------------------------------------------


            // nustatome, kad turi buti uzpildyti visi privalomi laikai, kad veiktu mogtukas "Apskaiciuoti"
            if (piDataNuo.Text == "" || piDataIki.Text == "" || piDydis.Text == "")
            {
                MessageBox.Show("Reikia uzpildyti visus privalomus laukus", "Klaida!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DateTime piDataNuo1 = Convert.ToDateTime(piDataNuo.Text);
                DateTime piDataIki1 = Convert.ToDateTime(piDataIki.Text);
                double piDydis1 = Convert.ToDouble(piDydis.Text);

                //einamoji data
                DateTime today = DateTime.Today;
                //data iki kurios apskaitomas islaikymas
                DateTime dataPabaiga = new DateTime(piDataIki1.Year, piDataIki1.Month, 1);
                DateTime today1 = new DateTime(today.Year, today.Month, 1);
                DateTime dataPabaiga1 = Convert.ToDateTime("2008-02-01");
                if (today > piDataIki1)
                {
                    dataPabaiga1 = dataPabaiga;
                }
                else
                {
                    dataPabaiga1 = today1;
                }
                piData.Text = dataPabaiga1.ToString();



                // Apskaiciuojame islaikymo suma uz pirma menesi nuo kurio pradedame skaiciuoti islaikyma
                // nustatome kiek dienu yra pirmame menesije nuo kada pradedame skaiciuoti islaikyma
                int daysMonth = DateTime.DaysInMonth(piDataNuo1.Year, piDataNuo1.Month);
                // nustatome kiek dienu liko iki sio pirmo menesio pabaigos, kad gali butu procentaliai apskaiciuoti susidarusio isiskolinimo dydi
                int daysLeft = DateTime.DaysInMonth(piDataNuo1.Year, piDataNuo1.Month) - piDataNuo1.Day;
                //apskaiciuojame islaikymo suma uz si pirma menesi - reikalinga galutinei islaikymo sumai iki indeksavimo pradzios apskaiciuoti
                double suma1 = Math.Round((daysLeft * piDydis1 / daysMonth), 2);

                // Nustatome reiksmes nuo kuriu taikomas indeksas
                DateTime vkiData1 = piDataNuo1.AddMonths(6);
                if (vkiData1 < Convert.ToDateTime("2008-02-01"))
                {
                    vkiData1 = Convert.ToDateTime("2008-02-01");
                }
                int id0 = 0;
                int id1 = 0;
                DateTime dataNuo1 = Convert.ToDateTime("2008-02-01");
                foreach (var item in vki)
                {
                    if (item.DataNuo < vkiData1 && item.DataIki >= vkiData1)
                    {
                        id0 = item.Id;
                    }
                    if (item.Id==id0+1)
                    {
                        id1 = id0 + 1; // ID nuo kurio taikomas indeksavimas
                        dataNuo1 = item.DataNuo;
                    }
                }
                // nustatome kiek yra menesiu iki indeksavimo pradzios
                int monthLeft1 = (dataNuo1.Year - piDataNuo1.Year)*12 + (dataNuo1.Month - piDataNuo1.Month)-((dataNuo1.Day - piDataNuo1.Day) > 0 ? 0 : 1);
                // apskaiciuojame galutine islaikymo suma iki indeksavimo pradzios
                double suma2 = Math.Round((monthLeft1 * piDydis1) + suma1, 2);
                
                // nustatome reiksmes iki kada bus taikomas ciklas ir kokios reiksmes bus naudojamos po jo
                int id2 = 0;
                DateTime dataNuo2 = Convert.ToDateTime("2008-02-01");
                foreach (var item in vki)
                {
                    if (item.DataNuo < piDataIki1 && item.DataIki >= piDataIki1)
                    {
                        id2 = item.Id;
                    }
                    if (item.Id == id2 + 1)
                    {
                        dataNuo2 = item.DataNuo; // data, kuri bus reikalinga menesiams po ciklo apskaiciuoti
                    }
                }
                
                // ciklas indeksuotai sumai apskaiciuoti
                double suma3 = 0;
                foreach (var item in vki)
                {
                    if (item.Id >= id1 && item.Id < id2)
                    {
                        suma3 += Math.Round(piDydis1 * ((item.Indeksas >= 101) ? (item.Indeksas / 100) : 1), 0)*12;
                    }
                }

                // islaikymo sumos po ciklo apskaiciavimas
                // nustatomas indeskuoto islaikymo dydis po ciklo, kuris bus taikomas islaikymo sumai po ciklo apskaiciuoti
                double piDydis2 = 0;
                double piDydis3 = 0;
                foreach (var item in vki)
                {
                    if (item.Id == id1)
                    {
                        piDydis2 = Math.Round(piDydis1 * ((item.Indeksas >= 101) ? (item.Indeksas / 100) : 1), 0) - piDydis1;
                    }
                    if (item.Id >= id1 && item.Id <= id2)
                    {
                        piDydis3 += Math.Round(piDydis1 * ((item.Indeksas >= 101) ? (item.Indeksas / 100) : 1), 0) - piDydis1;
                    }
                }
                double piDydis4 = piDydis1 + (piDydis3 - piDydis2);
                // nustatome menesiu skaiciu po ciklo pabaigos kurie bus taikomi indeksavimui apskaiciuoti moketina islaikymo suma po ciklo
                int monthLeft2 = (dataPabaiga1.Month - dataNuo2.Month);
                // apskaiciuojame moketina islaikymo suma po ciklo
                double suma4 = piDydis4 * monthLeft2;

                // Bendra moketina priteisto materialinio islaikymo suma
                double suma = suma1 + suma2 + suma3 + suma4;
                textBoxSuma.Text = suma.ToString();
            }
        }
    }
}

