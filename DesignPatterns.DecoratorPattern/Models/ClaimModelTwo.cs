using DesignPatterns.DecoratorPattern.Decorators;
using DesignPatterns.DecoratorPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorPattern.Models
{
    public class ClaimModelTwo : ClaimDecorator
    {
        public ClaimModelTwo(IClaimModel claim) : base(claim)
        {
        }

        public override double Value()
        {
            return base.Value() + 250;
        }

        public override List<string> Requirements()
        {
            var baseRequirements = base.Requirements();

            baseRequirements.Add("FICA check.");

            return baseRequirements;
        }
    }
}
