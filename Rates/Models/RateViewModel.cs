using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rates.Models
{
    public class RateViewModel
    {
        public DateTime dt { 
            get { return DateTime.Today; }
            set { this.dt = value; }
        }
        public ContractRate rate { get; set; }
        public Location loc { get; set; }
    }
}
