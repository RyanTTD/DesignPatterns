using DesignPatterns.FactoryPattern.Helpers;
using DesignPatterns.FactoryPattern.Interfaces;
using DesignPatterns.FactoryPattern.Models.Communication;
using DesignPatterns.FactoryPattern.Models.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryPattern.Factories
{
    public class CommunicationFactory
    {
        public ICommunicationAction GenerateCommunicationHelper(ICommunicationModel communicationModel) 
        {
            ICommunicationAction action = communicationModel switch
            {
                SMSCommunicationModel smsConfig => new SMSAction(smsConfig),
                EmailCommunicationModel emailConfig => new EmailAction(emailConfig),
                _ => new FaultedAction()
            };

            return action;
        }
    }
}
