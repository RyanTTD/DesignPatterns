using DesignPatterns.FactoryPattern.Models.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryPattern.Models.Interfaces
{
    public interface ICommunicationConfiguration
    {
        string FromAddress { get; set; }
        public string FromName { get; set; }
    }
}
