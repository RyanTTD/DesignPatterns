using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractPattern.Models
{
    public abstract class PremiumCalculationModel
    {
        public Guid PremiumId { get; set; }
        public decimal BasePremiumValue { get; set; }
        public decimal VATPercentage { get; set; }
        public decimal FinalPremium
        {
            get
            {
                return BasePremiumValue + (BasePremiumValue * VATPercentage / 100) + CalculateMarkup();
            }
        }
        public abstract decimal CalculateMarkup();

        public abstract string CalculationExplaination();
    }
}
