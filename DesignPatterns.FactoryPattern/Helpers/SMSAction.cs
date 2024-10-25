using DesignPatterns.FactoryPattern.Enum;
using DesignPatterns.FactoryPattern.Interfaces;
using DesignPatterns.FactoryPattern.Models.Communication;
using DesignPatterns.FactoryPattern.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryPattern.Helpers
{
    public class SMSAction : ICommunicationAction
    {
        private SMSCommunicationModel _smsModel;

        public SMSAction(SMSCommunicationModel model)
        {
            _smsModel = model;
        }

        public ActionStatusEnum ActionStatus { get; set; } = ActionStatusEnum.Created;

        public void SendCommunication()
        {
            ActionStatus = ActionStatusEnum.SMSSent;
        }
    }
}
