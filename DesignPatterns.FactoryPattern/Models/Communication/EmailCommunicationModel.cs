using DesignPatterns.FactoryPattern.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryPattern.Models.Communication
{
    public class EmailCommunicationModel : ICommunicationModel
    {
        public int SMTPPort { get; set; }
        public string FromEmailAddress { get; set; }
        public string FromName { get; set; }
        public string ToName { get; set; }
        public string ToEmailAddress { get; set; }
        public string Message { get; set; }
    }
}
