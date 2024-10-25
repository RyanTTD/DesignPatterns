using DesignPatterns.FactoryPattern.Builders;
using DesignPatterns.FactoryPattern.Factories;
using DesignPatterns.FactoryPattern.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryPattern
{
    public class FactoryPatternExecution
    {
        public void Execute()
        {
            var communicationFactory = new CommunicationFactory();
            var dataModel = new CommunicationDataBuilder().BuildPolicyCommunication();
            var communicationHelper = communicationFactory.GenerateCommunicationHelper(dataModel);
            communicationHelper.SendCommunication();

            Console.WriteLine(communicationHelper.ActionStatus);
        }
    }
}
