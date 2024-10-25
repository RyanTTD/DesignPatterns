using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractPattern.Helper
{
    public class TyrePremiumCalculationHelper : PremiumCalculationHelper
    {
        public override string CreatePremium()
        {
            return "I created a Tyre Premium.";
        }
    }
}
