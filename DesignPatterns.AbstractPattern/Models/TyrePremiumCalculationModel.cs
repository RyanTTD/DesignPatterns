using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractPattern.Models
{
    public class TyrePremiumCalculationModel : PremiumCalculationModel
    {
        public override decimal CalculateMarkup()
        {
            return 0;
        }

        public override string CalculationExplaination()
        {
            return "This is a Tyre Premium Calculation. The calculation is done by adding VAT onto the Base Premium Value and then adding a markup.";
        }
    }
}
