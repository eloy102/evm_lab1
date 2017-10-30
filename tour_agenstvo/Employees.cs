using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace tour_agenstvo
{
    [Table("Employees")]
    public class Employees
    {
        [Key]
        public int id_empoyer { get; set; }
        public string FIO { get; set; }
        public int pasport_serial { get; set; }
        public int pasport_num { get; set; }
        public string birthday { get; set; }
        public string Registration { get; set; }
        public string Position { get; set;}
        public double Salary { get; set; }

        public Employees(string FIO, int pasport_serial,int pasport_num,string birthday,string Registration, string Position, double Salary)
        {
            this.FIO = FIO;
            this.pasport_serial = pasport_serial;
            this.pasport_num = pasport_num;
            this.birthday = birthday;
            this.Registration = Registration;
            this.Position = Position;
            this.Salary = Salary;
        }
    }
}
