using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace tour_agenstvo
{
    [Table("Tours")]
    public class Tours
    {
        [Key]
        int id_tour { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string Sity { get; set; }
        public string Hotel { get; set; }
        public double Summ { get; set; }
        
        public Tours(int id_tour,string name,string country, string sity,string hotel,double summ)
        {
            this.id_tour = id_tour;
            this.Name = name;
            this.Country = country;
            this.Sity = sity;
            this.Hotel = hotel;
            this.Summ = summ;
        }
    }
}
