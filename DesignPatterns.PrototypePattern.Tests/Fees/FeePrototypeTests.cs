using DesignPatterns.PrototypePattern.Enums;
using DesignPatterns.PrototypePattern.Fees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PrototypePattern.Tests.Models
{
    [TestFixture]
    public class FeePrototypeTests
    {
        [TestFixture]
        public class FeePrototypeTest
        {
            [Test]
            public void GivenWeeklyFeeType_ShouldCloneToNextWeek()
            {
                // arrange
                var feePrototype = new FeePrototype
                {
                    FeeAmount = 1,
                    FeeDate = DateTime.Today,
                    FeeTypeId = (int)FeeTypeEnum.Weekly,
                    Version = 1,
                    IncreaseRate = 0.05m
                };

                var expectedVersion = feePrototype.Version + 1;
                var expecetFee = feePrototype.FeeAmount;
                var expectedDate = feePrototype.FeeDate.AddDays(7);

                // act
                var newFee = feePrototype.Clone() as FeePrototype;

                // assert
                Assert.That(newFee.Version, Is.EqualTo(expectedVersion));
                Assert.That(newFee.FeeAmount, Is.EqualTo(expecetFee));
                Assert.That(newFee.FeeDate, Is.EqualTo(expectedDate));
            }

            [Test]
            public void GivenMonthlyFeeType_ShouldCloneToNextMonth()
            {
                // arrange
                var feePrototype = new FeePrototype
                {
                    FeeAmount = 1,
                    FeeDate = DateTime.Today,
                    FeeTypeId = (int)FeeTypeEnum.Monthly,
                    Version = 1,
                    IncreaseRate = 0.05m
                };

                var expectedVersion = feePrototype.Version + 1;
                var expecetFee = feePrototype.FeeAmount;
                var expectedDate = feePrototype.FeeDate.AddMonths(1);

                // act
                var newFee = feePrototype.Clone() as FeePrototype;

                // assert
                Assert.That(newFee.Version, Is.EqualTo(expectedVersion));
                Assert.That(newFee.FeeAmount, Is.EqualTo(expecetFee));
                Assert.That(newFee.FeeDate, Is.EqualTo(expectedDate));
            }

            [Test]
            public void GivenAnnualFeeType_ShouldCloneToNextYear()
            {
                // arrange
                var feePrototype = new FeePrototype
                {
                    FeeAmount = 1,
                    FeeDate = DateTime.Today,
                    FeeTypeId = (int)FeeTypeEnum.Annually,
                    Version = 1,
                    IncreaseRate = 0.05m
                };

                var expectedVersion = feePrototype.Version + 1;
                var expecetFee = feePrototype.FeeAmount + (feePrototype.FeeAmount * feePrototype.IncreaseRate);
                var expectedDate = feePrototype.FeeDate.AddYears(1);

                // act
                var newFee = feePrototype.Clone() as FeePrototype;

                // assert
                Assert.That(newFee.Version, Is.EqualTo(expectedVersion));
                Assert.That(newFee.FeeAmount, Is.EqualTo(expecetFee));
                Assert.That(newFee.FeeDate, Is.EqualTo(expectedDate));
            }

            [Test]
            public void GivenIncorrectFeeType_ShouldCloneWithError()
            {
                // arrange
                var feePrototype = new FeePrototype
                {
                    FeeAmount = 1,
                    FeeDate = DateTime.Today,
                    FeeTypeId = 0,
                    Version = 1,
                    IncreaseRate = 0.05m
                };

                // act
                var newFee = feePrototype.Clone() as FeePrototype;

                // assert
                Assert.That(newFee.ErroredFee, Is.EqualTo(true));
            }
        }
    }
}
