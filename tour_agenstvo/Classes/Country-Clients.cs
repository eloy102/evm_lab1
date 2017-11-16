using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tour_agenstvo
{
    public class Country_Clients
    {
        public string Country { get; set; }
        public string FIO { get; set; }
        public string Tour { get; set; }
        public int Adult_Count { get; set; }
        public int Child_count { get; set; }
        public decimal Summ { get; set; }

        public Country_Clients()
        { }
    }
}
