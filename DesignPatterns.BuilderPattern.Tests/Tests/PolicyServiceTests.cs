using DesignPatterns.BuilderPattern.Models;
using DesignPatterns.BuilderPattern.Repositories;
using DesignPatterns.BuilderPattern.Tests.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern.Tests.Tests
{
    [TestFixture]
    public class PolicyServiceTests
    {
        [TestFixture]
        public class CreatePolicy
        {
            [Test]
            public void GivenData_ShouldCreatePolicy()
            {
                // Arrange
                var inputData = new CreatePolicyModel
                {
                    IDNumber = "1234567890",
                    Name = "Ryan",
                    ProductId = Guid.NewGuid()
                };

                var policyRepository = new PolicyRepository();
                var customerRepository = new CustomerRepository();
                
                var policyService = new PolicyServiceBuilder()
                    .WithPolicyRepository(policyRepository)
                    .WithCustomerRepository(customerRepository)
                    .Build();

                // Act
                var result = policyService.CreatePolicy(inputData);

                // Assert
                Assert.That(result, Is.Not.Null);
            }

            [Test]
            public void GivenNoCustomerRepository_ShouldReturnNull()
            {
                // Arrange
                var inputData = new CreatePolicyModel
                {
                    IDNumber = "1234567890",
                    Name = "Ryan",
                    ProductId = Guid.NewGuid()
                };

                var policyRepository = new PolicyRepository();

                var policyService = new PolicyServiceBuilder()
                    .WithPolicyRepository(policyRepository)
                    .Build();

                // Act
                var result = policyService.CreatePolicy(inputData);

                // Assert
                Assert.That(result, Is.Null);
            }

            [Test]
            public void GivenNoPolicyRepository_ShouldReturnNull()
            {
                // Arrange
                var inputData = new CreatePolicyModel
                {
                    IDNumber = "1234567890",
                    Name = "Ryan",
                    ProductId = Guid.NewGuid()
                };

                var customerRepository = new CustomerRepository();

                var policyService = new PolicyServiceBuilder()
                    .WithCustomerRepository(customerRepository)
                    .Build();

                // Act
                var result = policyService.CreatePolicy(inputData);

                // Assert
                Assert.That(result, Is.Null);
            }
        }
    }
}
