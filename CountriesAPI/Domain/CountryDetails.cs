using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountriesAPI.Domain
{
    internal class CountryDetails
    {
        public string region { get; set; }
        public string subregion { get; set; }
        public decimal[] latlng { get; set; }
        public decimal area { get; set; }
        public decimal population { get; set; }
    }
}
