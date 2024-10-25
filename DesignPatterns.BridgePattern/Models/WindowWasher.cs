using DesignPatterns.BridgePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BridgePattern.Models
{
    public class WindowWasher : IWasher
    {
        public void SetDirection(int direction)
        {
            Console.WriteLine("Direction: " + direction);
        }

        public void StartWashing()
        {
            Console.WriteLine("Started Washing");
        }

        public void StopWashing()
        {
            Console.WriteLine("Stopped Washing");
        }
    }
}
