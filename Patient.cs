using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Patient
    {
        public int id;
        public string Name;
        public string First_Name;
        public DateTime date;
        public string male;
        public string diagnoz;
        public string history;

        public  Patient(int id,string Name,string First_Name,DateTime date,string male,string diagnoz,string history)
        {
            this.date = date;
            this.First_Name = First_Name;
            this.id = id;
            this.Name = Name;
            this.male = male;
            this.diagnoz = diagnoz;
            this.history = history;

        }
        public  int GetAge(DateTime birthDate)
        {
            var now = DateTime.Today;
            return now.Year - birthDate.Year - 1 +
                ((now.Month > birthDate.Month || now.Month == birthDate.Month && now.Day >= birthDate.Day) ? 1 : 0);
        }
    }
}
