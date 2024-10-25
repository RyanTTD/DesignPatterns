using DesignPatterns.BridgePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BridgePattern.Models
{
    public class MobileWasherRemote : WasherRemote
    {
        public MobileWasherRemote(IWasher washer) : base(washer)
        {
        }

        public bool IsWashing = false;
        public int Direction = 1;

        public override void SetDirection(int direction)
        {
            _washer.SetDirection(direction);
            Direction = direction;
        }

        public override void StartStop()
        {
            if (!IsWashing)
            {
                _washer.StopWashing();
            }
            else
            {
                _washer.StartWashing();
            }

            IsWashing = !IsWashing;
        }
    }
}
