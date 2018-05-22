using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Users
    {
        public string UserID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DoB { get; set; }
        public int Salary { get; set; }
        public int WorkYear { get; set; }

        public Users(string UserID, string Name, string Surname, DateTime DoB, int Salary, int WorkYear)
        {
            this.UserID = UserID;
            this.Name = Name;
            this.Surname = Surname;
            this.DoB = DoB;
            this.Salary = Salary;
            this.WorkYear = WorkYear;
        }
    }
}
