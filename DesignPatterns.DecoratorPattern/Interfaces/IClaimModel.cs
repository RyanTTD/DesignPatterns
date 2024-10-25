using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorPattern.Interfaces
{
    public interface IClaimModel
    {
        double Value();
        List<string> Requirements();
    }
}
