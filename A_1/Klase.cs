using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_1
{
    public class Klase: Mokykla
    {
        public List<string> MokiniaiVardai { get; set; }
        public int[] MokiniaiVidurkis { get; set; }

        public Klase(int Klase, char KlaseRaide, int MokiniaiSkaicius, DateTime MoksluPradzia, List<string> MokiniaiVardai, int[] MokiniaiVidurkis)
            : base(Klase, KlaseRaide, MokiniaiSkaicius, MoksluPradzia)
        {
            this.MokiniaiVardai = MokiniaiVardai;
            this.MokiniaiVidurkis = MokiniaiVidurkis;
        }
        public Klase()
        {
        }


    }
}
