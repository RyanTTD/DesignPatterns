using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AdapterPattern.Interfaces
{
    public interface IPolicyFeeAdapter
    {
        int FamilyMembers { get; set; }
        string PolicyHolderName { get; }
        string PolicyType { get; }
        decimal BaseFee { get; }
        decimal Fee { get; }
        decimal PolicyFeeDiscount { get; }
        decimal PolicyFeeDiscountValue { get; }
    }
}
