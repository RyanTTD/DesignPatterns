using DesignPatterns.BridgePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BridgePattern.Models
{
    public abstract class WasherRemote
    {
        protected IWasher _washer;

        protected WasherRemote(IWasher washer)
        {
            _washer = washer;
        }

        public abstract void StartStop();
        public abstract void SetDirection(int direction);
    }
}
