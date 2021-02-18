using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rates.Models
{
    public class Location
    {
        public string HomeZIP { get; set; }
        public string JobZIP { get; set; }
        public double distance { get; set; }
    }
}
