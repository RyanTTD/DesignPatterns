using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryPattern.Enum
{
    public enum ActionStatusEnum
    {
        Created = 1,
        SMSSent = 2,
        EmailSent = 3,
        Faulted = 4
    }
}
