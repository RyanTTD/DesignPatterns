using DesignPatterns.BuilderPattern.Models;
using DesignPatterns.BuilderPattern.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern.Services
{
    public class PolicyService : IPolicyService
    {
        private readonly IPolicyRepository _policyRepository;
        private readonly ICustomerRepository _customerRepository;

        public PolicyService(IPolicyRepository policyRepository, ICustomerRepository customerRepository)
        {
            _policyRepository = policyRepository;
            _customerRepository = customerRepository;
        }

        public PolicyModel CreatePolicy(CreatePolicyModel model)
        {
            if (_customerRepository == null) return null;
            if (_policyRepository == null) return null;

            var customer = _customerRepository.CreateCustomer(model);
            var policy = _policyRepository.CreatePolicy(model);

            return policy;
        }
    }
}
