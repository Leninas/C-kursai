using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_1
{
    public class Mokykla
    {
        public int Klase { get; set; }
        public char KlaseRaide { get; set; }
        public int MokiniaiSkaicius { get; set; }
        public DateTime MoksluPradzia { get; set; }

        public Mokykla(int Kalse, char KlaseRaide, int MokiniaiSkaicius, DateTime MoksluPradzia)
        {
            this.Klase = Klase;
            this.KlaseRaide = KlaseRaide;
            this.MokiniaiSkaicius = MokiniaiSkaicius;
            this.MoksluPradzia = MoksluPradzia;
        }

        public Mokykla()
        {
        }

        public int MoksluTrukme()

        {
            return DateTime.Today.Year - MoksluPradzia.Year;
        }
    }
}
