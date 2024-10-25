using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BridgePattern.Interfaces
{
    public interface IWasher
    {
        void StartWashing();
        void StopWashing();
        void SetDirection(int  direction);
    }
}
