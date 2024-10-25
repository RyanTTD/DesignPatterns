using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AdapterPattern.Models
{
    public class PolicyFeeInputData
    {
        public string PolicyHolderName { get; set; }
        public string PolicyType { get; set; }
        public decimal Fee { get; set; }
        public int FamilyMembers { get; set; }
    }
}
