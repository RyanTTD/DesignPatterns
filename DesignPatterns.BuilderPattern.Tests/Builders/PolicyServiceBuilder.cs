using DesignPatterns.BuilderPattern.Repositories;
using DesignPatterns.BuilderPattern.Services;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern.Tests.Builders
{
    public class PolicyServiceBuilder
    {
        private IPolicyRepository _policyRepository;
        private ICustomerRepository _customerRepository;

        public PolicyServiceBuilder WithPolicyRepository(IPolicyRepository policyRepository)
        {
            _policyRepository = policyRepository;
            return this;
        }

        public PolicyServiceBuilder WithCustomerRepository(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
            return this;
        }

        public PolicyService Build()
        {
            return new PolicyService(_policyRepository, _customerRepository);
        }
    }
}
