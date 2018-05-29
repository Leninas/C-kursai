using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace _24_4_daug_duomenu
{
    class FromFileToSQL
    {
        public void Converter(string path)
        {
            StreamReader reader = new StreamReader(path);
            string data = reader.ReadToEnd();
            data = data.Replace("\n", "");
            data = data.Replace("\r", "");
            data = data.Replace(".", ",");
            string[] dataString = data.Split(';');
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\aleni\source\repos\Programavimo_Kursai_C_sharp\24_4_daug_duomenu\DataBig.mdf;Integrated Security=True";
            reader.Dispose();

            DataContext db = new DataContext(connectionString);
            Table < Sensor > sensor = db.GetTable<Sensor>();
            Table < Measurement > measurements = db.GetTable<Measurement>();

            Sensor sen = new Sensor();
            sen.Id = long.Parse(dataString[93]);
            sen.DateOfRecord = DateTime.Parse(dataString[90]);
            sen.StationNumber = dataString[91];
            sen.SV = int.Parse(dataString[96]);

            for (int i = 100; i < dataString.Length-2; i+=5)
            {
                Measurement temp = new Measurement();
                temp.SN = long.Parse(dataString[93]);
                temp.Position = decimal.Parse(dataString[i]);
                temp.Vout = decimal.Parse(dataString[i+1]);
                temp.Min = decimal.Parse(dataString[i+3]);
                temp.Max = decimal.Parse(dataString[i+4]);

                measurements.InsertOnSubmit(temp);
                db.SubmitChanges();
            }

            sensor.InsertOnSubmit(sen);
            db.SubmitChanges();
        }
    }
}
