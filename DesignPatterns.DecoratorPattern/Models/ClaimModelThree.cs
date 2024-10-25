using DesignPatterns.DecoratorPattern.Decorators;
using DesignPatterns.DecoratorPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorPattern.Models
{
    public class ClaimModelThree : ClaimDecorator
    {
        public ClaimModelThree(IClaimModel claim) : base(claim)
        {
        }

        public override double Value()
        {
            return base.Value() + 350;
        }

        public override List<string> Requirements()
        {
            var baseRequirements = base.Requirements();

            baseRequirements.Add("Criminal check.");
            baseRequirements.Add("RICA check.");

            return baseRequirements;
        }
    }
}
