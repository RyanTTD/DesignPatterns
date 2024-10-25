using DesignPatterns.FactoryPattern.Enum;
using DesignPatterns.FactoryPattern.Interfaces;
using DesignPatterns.FactoryPattern.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryPattern.Helpers
{
    public class FaultedAction : ICommunicationAction
    {
        public ActionStatusEnum ActionStatus { get; set; } = ActionStatusEnum.Faulted;

        public void SendCommunication()
        {
        }
    }
}
