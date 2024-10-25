using DesignPatterns.DecoratorPattern.Interfaces;

namespace DesignPatterns.DecoratorPattern.Models
{
    public class ClaimModel : IClaimModel
    {
        public double ClaimValue { get; set; }
        public List<string> ClaimRequirements { get; set; }

        public double Value()
        {
            return ClaimValue;
        }

        public List<string> Requirements()
        {
            return ClaimRequirements;
        }
    }
}
