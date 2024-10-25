using DesignPatterns.AbstractPattern.Models;

namespace DesignPatterns.AbstractPattern
{
    public class AbstractPatternExecution
    {
        public static void Execute()
        {
            PremiumCalculationModel calculationModel = new CarPremiumCalculationModel
            {
                VATPercentage = 15,
                BasePremiumValue = 100,
                PremiumId = Guid.NewGuid()
            };

            Console.WriteLine(calculationModel.CalculationExplaination());
            Console.WriteLine("Base Value: " + calculationModel.BasePremiumValue);
            Console.WriteLine("VAT Percentage: " + calculationModel.VATPercentage);
            Console.WriteLine("Markup: " + calculationModel.CalculateMarkup());
            Console.WriteLine("Final Premium: " + calculationModel.FinalPremium);
        }
    }
}