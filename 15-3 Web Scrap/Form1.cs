using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15_3_Web_Scrap
{
    public partial class Form1 : Form
    {
        private static IEnumerable<DirectoryInfo> cDirs;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var url = textBox1.Text;
            //textBox1.Text = "";
            var url = "https://www.evarzytynes.lt/evs/pages/auctions.do";
            GautiHTML(url);

            //var htmlDoc = new HtmlAgilityPack.HtmlDocument();
            //htmlDoc.LoadHtml(html);

            //var htmlNodes = htmlDoc.DocumentNode.SelectNodes("<td>");
            //MessageBox.Show(htmlDoc.InnerText);
        }

        private static async void GautiHTML(string url)
        {
            var httpClient = new HttpClient();
            var html = await httpClient.GetStringAsync(url);
            var htmlDocument = new HtmlAgilityPack.HtmlDocument();
            htmlDocument.LoadHtml(html);

            var produktuSarasas = htmlDocument.DocumentNode.Descendants("li")
                .Where(x => x.GetAttributeValue("class", "")
                    .Equals("sep")).ToList();

            //var produktuElementai = produktuSarasas[0].Descendants("td")
            //     .Where(x => x.GetAttributeValue("class", "")
            //        .Equals("left")).ToList();

            foreach (var htmlNode in produktuSarasas)
            {
                //rezultatas isvedamas text boxe
                //MessageBox.Show(htmlNode.InnerText);

                //Rezultatas irasomas i faila
                // Get the directories currently on the C drive.
                //DirectoryInfo[] cDirs = new DirectoryInfo(@"C:\Users\aleni\Desktop\C mokymai").GetDirectories();

                // Write each directory name to a file. - irasymas i faila
                using (StreamWriter sw = new StreamWriter(@"C: \Users\aleni\Desktop\C mokymai\DriveDirs.txt", append: true))
                {
                    //foreach (DirectoryInfo dir in cDirs)
                    //{
                        sw.WriteLine(htmlNode.InnerText.Trim());
                    //}
                }

                // Read and show each line from the file. - nuskaitymas failo
                //string line = "";
                //using (StreamReader sr = new StreamReader("CDriveDirs.txt"))
                //{
                //    while ((line = sr.ReadLine()) != null)
                //    {
                //        Console.WriteLine(line);
                //    }
                //}
            }

            Application.Exit();
            //public void Close(); - meta claida
        }

    }
}
