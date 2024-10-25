using DesignPatterns.BuilderPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern.Repositories
{
    public interface ICustomerRepository
    {
        CustomerModel CreateCustomer(CreatePolicyModel model);
    }
}
