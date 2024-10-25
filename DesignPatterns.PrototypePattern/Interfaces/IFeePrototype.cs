using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PrototypePattern.Interfaces
{
    public interface IFeePrototype
    {
        IFeePrototype Clone();
    }
}
