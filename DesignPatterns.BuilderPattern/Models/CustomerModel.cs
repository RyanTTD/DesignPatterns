using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern.Models
{
    public class CustomerModel
    {
        public Guid CustomerId { get; set; }
        public string Name { get; set; }
        public string IDNumber { get; set; }
    }
}
