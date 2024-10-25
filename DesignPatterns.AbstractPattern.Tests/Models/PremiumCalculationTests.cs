using DesignPatterns.AbstractPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractPattern.Tests.Models
{
    [TestFixture]
    public class PremiumCalculationTests
    {
        [TestFixture]
        public class PremiumCalculation
        {
            [Test]
            public void ShouldReturnCarPremiumCalculation()
            {
                // Arrange
                var expectedExplaination = "This is a Car Premium Calculation. The calculation is done by adding VAT onto the Base Premium Value.";
                var expectedFinalPremium = 125;

                // Act
                PremiumCalculationModel calculationModel = new CarPremiumCalculationModel
                {
                    VATPercentage = 15,
                    BasePremiumValue = 100,
                    PremiumId = Guid.NewGuid()
                };

                // Assert
                Assert.That(expectedExplaination, Is.EqualTo(calculationModel.CalculationExplaination()));
                Assert.That(expectedFinalPremium, Is.EqualTo(calculationModel.FinalPremium));
            }

            [Test]
            public void ShouldReturnTyrePremiumCalculation()
            {
                // Arrange
                var expectedExplaination = "This is a Tyre Premium Calculation. The calculation is done by adding VAT onto the Base Premium Value and then adding a markup.";
                var expectedFinalPremium = 115;

                // Act
                PremiumCalculationModel calculationModel = new TyrePremiumCalculationModel
                {
                    VATPercentage = 15,
                    BasePremiumValue = 100,
                    PremiumId = Guid.NewGuid()
                };

                // Assert
                Assert.That(expectedExplaination, Is.EqualTo(calculationModel.CalculationExplaination()));
                Assert.That(expectedFinalPremium, Is.EqualTo(calculationModel.FinalPremium));
            }
        }
    }
}
