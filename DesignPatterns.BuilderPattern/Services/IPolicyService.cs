using DesignPatterns.BuilderPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern.Services
{
    public interface IPolicyService
    {
        PolicyModel CreatePolicy(CreatePolicyModel model);
    }
}
