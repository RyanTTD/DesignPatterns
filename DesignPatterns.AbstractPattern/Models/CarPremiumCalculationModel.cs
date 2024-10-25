using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractPattern.Models
{
    public class CarPremiumCalculationModel : PremiumCalculationModel
    {
        public override decimal CalculateMarkup()
        {
            return (BasePremiumValue * 10 / 100);
        }

        public override string CalculationExplaination()
        {
            return "This is a Car Premium Calculation. The calculation is done by adding VAT onto the Base Premium Value.";
        }
    }
}
