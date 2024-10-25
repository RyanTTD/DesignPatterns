using DesignPatterns.PrototypePattern.Enums;
using DesignPatterns.PrototypePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PrototypePattern.Fees
{
    public class FeePrototype : IFeePrototype
    {
        public decimal FeeAmount { get; set; }
        public decimal IncreaseRate { get; set; }
        public int Version { get; set; }
        public int FeeTypeId { get; set; }
        public DateTime FeeDate { get; set; }
        public bool ErroredFee { get; set; }

        public IFeePrototype Clone()
        {
            var clonedFee = (FeePrototype)MemberwiseClone();
            clonedFee.Version += 1;

            switch (FeeTypeId)
            {
                case (int)FeeTypeEnum.Weekly:
                    {
                        clonedFee.FeeDate = FeeDate.AddDays(7);
                        break;
                    }
                case (int)FeeTypeEnum.Monthly:
                    {
                        clonedFee.FeeDate = FeeDate.AddMonths(1);
                        break;
                    }
                case (int)FeeTypeEnum.Annually:
                    {
                        clonedFee.FeeDate = FeeDate.AddYears(1);
                        clonedFee.FeeAmount += clonedFee.FeeAmount * clonedFee.IncreaseRate;
                        break;
                    }
                default:
                    {
                        clonedFee.ErroredFee = true;
                        break;
                    }
            }

            return clonedFee;
        }
    }
}
