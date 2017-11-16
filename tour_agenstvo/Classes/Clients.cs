using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace tour_agenstvo
{   
    [Table("Clients")]
    public class Clients
    {
        [Key]
        public int id { get; set; }
        public string FIO { get; set; }
        public int pasport_serial { get; set; }
        public int pasport_num { get; set; }
        public string birthday { get; set; }
        public string Registration { get; set; }
        public int id_tour { get; set; }
        public int Adult_count { get; set; }
        public int Children_Count { get; set; }
        public decimal Summ { get; set; }

        public Clients(int id, string FIO, int pasport_serial, int pasport_num, string birthday, string registration, int id_tour, int Adult_count, int Children_Count, decimal summ)
        {
            this.id = id;
            this.FIO = FIO;
            this.pasport_serial = pasport_serial;
            this.pasport_num = pasport_serial;
            this.birthday = birthday;
            this.Registration = registration;
            this.id_tour = id_tour;
            this.Adult_count = Adult_count;
            this.Children_Count = Children_Count;
            this.Summ = summ;
        }
    }
}
