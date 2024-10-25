using DesignPatterns.FactoryPattern.Models.Communication;
using DesignPatterns.FactoryPattern.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryPattern.Builders
{
    public class CommunicationDataBuilder
    {
        public ICommunicationModel BuildPolicyCommunication()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 4);

            switch (randomNumber)
            {
                case 1:
                    {
                        return BuildWithSMSCommunication();
                    }
                case 2:
                    {
                        return BuildWithEmailCommunication();
                    }
                default:
                    {
                        return null;
                    }
            }
        }

        public SMSCommunicationModel BuildWithSMSCommunication()
        {
            return new SMSCommunicationModel
            {
                FromNumber = "0987654321",
                FromName = "Johnny",
                Message = "Hello World",
                ToNumber = "0123456789",
                ToName = "Tom"
            };
        }

        public EmailCommunicationModel BuildWithEmailCommunication()
        {
            return new EmailCommunicationModel
            {
                ToEmailAddress = "test@me.co",
                ToName = "Johnny",
                FromEmailAddress = "hello@world.co",
                FromName = "Bye Silence",
                Message = "Hello World",
                SMTPPort = 1234
            };
        }
    }
}
