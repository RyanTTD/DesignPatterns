using DesignPatterns.FactoryPattern.Builders;
using DesignPatterns.FactoryPattern.Enum;
using DesignPatterns.FactoryPattern.Helpers;
using DesignPatterns.FactoryPattern.Models.Interfaces;

namespace DesignPatterns.FactoryPattern.Tests.Factories
{
    [TestFixture]
    public class CommunicationFactoryTests
    {
        [TestFixture]
        public class CommunicationFactory
        {
            [Test]
            public void GivenNoData_ShouldSetActionToFaulted()
            {
                // Arrange
                ICommunicationModel model = null;
                var communicationFactory = new DesignPatterns.FactoryPattern.Factories.CommunicationFactory();
                var communicationAction = communicationFactory.GenerateCommunicationHelper(model);

                // Act
                communicationAction.SendCommunication();

                // Assert
                Assert.That(ActionStatusEnum.Faulted, Is.EqualTo(communicationAction.ActionStatus));
            }

            [Test]
            public void GivenSMSCommunication_ShouldSetActionToSMSSent()
            {
                // Arrange
                ICommunicationModel model = new CommunicationDataBuilder().BuildWithSMSCommunication();
                var communicationFactory = new DesignPatterns.FactoryPattern.Factories.CommunicationFactory();
                var communicationAction = communicationFactory.GenerateCommunicationHelper(model);

                // Act
                communicationAction.SendCommunication();

                // Assert
                Assert.That(ActionStatusEnum.SMSSent, Is.EqualTo(communicationAction.ActionStatus));
            }

            [Test]
            public void GivenEmailCommunication_ShouldSetActionToEmailSent()
            {
                // Arrange
                ICommunicationModel model = new CommunicationDataBuilder().BuildWithEmailCommunication();
                var communicationFactory = new DesignPatterns.FactoryPattern.Factories.CommunicationFactory();
                var communicationAction = communicationFactory.GenerateCommunicationHelper(model);

                // Act
                communicationAction.SendCommunication();

                // Assert
                Assert.That(ActionStatusEnum.EmailSent, Is.EqualTo(communicationAction.ActionStatus));
            }
        }
    }
}