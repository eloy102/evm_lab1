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
        public int id_tour { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string Sity { get; set; }
        public string Hotel { get; set; }
        public decimal Summ { get; set; }
        
        public Tours(int id_tour,string Name,string Country, string Sity,string Hotel,decimal Summ)
        {
            this.id_tour = id_tour;
            this.Name = Name;
            this.Country = Country;
            this.Sity = Sity;
            this.Hotel = Hotel;
            this.Summ = Summ;
        }
    }
}
