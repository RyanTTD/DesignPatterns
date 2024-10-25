using DesignPatterns.AbstractPattern.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractPattern
{
    public class AbstractHelperPatternExecution
    {
        public void Execute() 
        {
            var helpOne = new LifePremiumCalculationHelper();

            Console.WriteLine(helpOne.CreatePremiumNumber());
            Console.WriteLine(helpOne.CreatePremium());

            var helpTwo = new TyrePremiumCalculationHelper();

            Console.WriteLine(helpTwo.CreatePremiumNumber());
            Console.WriteLine(helpTwo.CreatePremium());
        }
    }
}
