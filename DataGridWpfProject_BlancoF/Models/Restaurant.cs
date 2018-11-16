using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridWpfProject_BlancoF.Models
{

    public enum RestaurantType
    {
        AMERICAN,
        MEXICAN,
        ITALIAN,
        UNKNOWN
    }

    public class Restaurant
    {
        public string Name { get; set; }
        public RestaurantType Type { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int Rating { get; set; }
        public bool Open { get; set; }
    }
}
