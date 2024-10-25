using DesignPatterns.AbstractPattern.Helper;
using DesignPatterns.AbstractPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractPattern.Tests.Helpers
{
    [TestFixture]
    public class PremiumCalculationHelperTests
    {
        [TestFixture]
        public class PremiumCalculationHelper
        {
            [Test]
            public void ShouldReturnLifePremiumCreated()
            {
                // Arrange
                var expectedOutcome = "I created a Life Premium.";
                var expectedNumber = "prem-1";

                // Act
                var calculationHelper = new LifePremiumCalculationHelper();

                // Assert
                Assert.That(expectedOutcome, Is.EqualTo(calculationHelper.CreatePremium()));
                Assert.That(expectedNumber, Is.EqualTo(calculationHelper.CreatePremiumNumber()));
            }
        }

        [TestFixture]
        public class TyreCalculationHelper
        {
            [Test]
            public void ShouldReturnTyrePremiumCreated()
            {
                // Arrange
                var expectedOutcome = "I created a Tyre Premium.";
                var expectedNumber = "prem-1";

                // Act
                var calculationHelper = new TyrePremiumCalculationHelper();

                // Assert
                Assert.That(expectedOutcome, Is.EqualTo(calculationHelper.CreatePremium()));
                Assert.That(expectedNumber, Is.EqualTo(calculationHelper.CreatePremiumNumber()));
            }
        }
    }
}
