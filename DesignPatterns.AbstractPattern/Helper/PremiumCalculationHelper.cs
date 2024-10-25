using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractPattern.Helper
{
    public abstract class PremiumCalculationHelper
    {
        public string CreatePremiumNumber()
        {
            return "prem-1";
        }

        public abstract string CreatePremium();
    }
}
