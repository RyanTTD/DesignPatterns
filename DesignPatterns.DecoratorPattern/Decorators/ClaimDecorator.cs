using DesignPatterns.DecoratorPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorPattern.Decorators
{
    public class ClaimDecorator : IClaimModel
    {
        protected IClaimModel _decoratedClaim;

        public ClaimDecorator(IClaimModel claim)
        {
            this._decoratedClaim = claim;
        }

        public virtual double Value()
        {
            return _decoratedClaim.Value();
        }

        public virtual List<string> Requirements()
        {
            return _decoratedClaim.Requirements();
        }
    }
}
