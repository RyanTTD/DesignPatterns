using DesignPatterns.AbstractPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractPattern.Models
{
    public class PremiumModel : IPremiumModel
    {
        public string PremiumDescription { get; set; }

        public string GetMyName()
        {
            throw new NotImplementedException();
        }
    }
}
