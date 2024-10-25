using DesignPatterns.SingletonPattern.SingletonInstance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SingletonPatternTests.SingletonInstance
{
    [TestFixture]
    public class SingletonTests
    {
        [TestFixture]
        public class SingletonTest
        {
            [Test]
            public void GivenTwoInstances_ShouldBeTheSame()
            {
                // Arrange
                var firstInstance = Singleton.Instance;
                Singleton secondInstance;

                // Act
                secondInstance = Singleton.Instance;

                // Assert
                Assert.That(secondInstance, Is.SameAs(firstInstance));
            }
                
            [Test]
            public void GivenInstance_ShouldHaveDifferentMessageFromStart()
            {
                // Arrange
                var firstInstance = Singleton.Instance;
                string expectedOutcomeMessage = "Hello World.";
                string startingOutcomeMessage = firstInstance.ExecuteMethod();

                // Act
                firstInstance.myOutcome = expectedOutcomeMessage;

                // Assert
                Assert.That(expectedOutcomeMessage, Is.EqualTo(firstInstance.ExecuteMethod()));
                Assert.That(startingOutcomeMessage, Is.Not.EqualTo(firstInstance.ExecuteMethod()));
            }

            [Test]
            public void GivenInstances_ShouldDisplayMessage_AfterUpdate()
            {
                // Arrange
                var firstInstance = Singleton.Instance;
                var secondInstance = Singleton.Instance;
                string expectedOutcomeMessage = "Hello World.";

                // Act
                firstInstance.myOutcome = expectedOutcomeMessage;

                // Assert
                Assert.That(expectedOutcomeMessage, Is.EqualTo(secondInstance.ExecuteMethod()));
            }
        }
    }
}
