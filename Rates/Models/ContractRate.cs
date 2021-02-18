using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rates.Models
{
    public class ContractRate
    {
        public decimal Billing { get; set; }
        public decimal Overhead { get; set; }
        public double Margin { get; set; }
    }
}
