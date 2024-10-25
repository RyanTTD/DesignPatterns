using DesignPatterns.AdapterPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AdapterPattern.Models
{
    public class PolicyFee
    {
        public string PolicyHolderName { get; set; }
        public string PolicyType { get; set; }
        public decimal Fee { get; set; }
    }
}
