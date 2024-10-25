using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractPattern.Interfaces
{
    public interface IPremiumModel
    {
        string PremiumDescription { get; set; }
        string GetMyName();
    }
}
