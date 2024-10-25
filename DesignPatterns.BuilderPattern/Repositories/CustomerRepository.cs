using DesignPatterns.BuilderPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public CustomerModel CreateCustomer(CreatePolicyModel model)
        {
            return new CustomerModel
            {
                CustomerId = Guid.NewGuid(),
                Name = model.Name,
                IDNumber = model.IDNumber
            };
        }
    }
}
