using DesignPatterns.DecoratorPattern.Interfaces;
using DesignPatterns.DecoratorPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorPattern
{
    public class DecoratorPatternExecution
    {
        public void Execute()
        {
            IClaimModel initialClaim = new ClaimModel
            {
                ClaimValue = 500,
                ClaimRequirements = new List<string>()
            };

            Console.WriteLine("Initial Claim Value: " + initialClaim.Value());
            Console.WriteLine("Requirements:");

            foreach (var requirement in initialClaim.Requirements())
            {
                Console.WriteLine(requirement);
            }
            Console.WriteLine("");


            IClaimModel secondaryClaim = new ClaimModelTwo(initialClaim);

            Console.WriteLine("Secondary Claim Value: " + secondaryClaim.Value());
            Console.WriteLine("Requirements:");

            foreach (var requirement in secondaryClaim.Requirements())
            {
                Console.WriteLine(requirement);
            }
            Console.WriteLine("");

            IClaimModel tertiaryClaim = new ClaimModelThree(initialClaim);

            Console.WriteLine("Tertiary Claim Value: " + tertiaryClaim.Value());
            Console.WriteLine("Requirements:");

            foreach (var requirement in tertiaryClaim.Requirements())
            {
                Console.WriteLine(requirement);
            }

            Console.ReadLine();
        }
    }
}
