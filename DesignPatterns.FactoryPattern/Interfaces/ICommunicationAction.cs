using DesignPatterns.FactoryPattern.Enum;
using DesignPatterns.FactoryPattern.Models.Communication;
using DesignPatterns.FactoryPattern.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryPattern.Interfaces
{
    public interface ICommunicationAction
    {
        void SendCommunication();
        ActionStatusEnum ActionStatus { get; set; }
    }
}
