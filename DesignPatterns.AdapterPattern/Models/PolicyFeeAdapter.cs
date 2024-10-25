using DesignPatterns.AdapterPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AdapterPattern.Models
{
    public class PolicyFeeAdapter : IPolicyFeeAdapter
    {
        private readonly PolicyFee _individualPolicyFee;

        public PolicyFeeAdapter(PolicyFee individualPolicyFee)
        {
            _individualPolicyFee = individualPolicyFee;
        }

        public int FamilyMembers { get; set; }

        public decimal PolicyFeeDiscount
        {
            get
            {
                if(FamilyMembers < 2) return 0;

                switch (FamilyMembers)
                {
                    case 2:
                        {
                            return 5m;
                        }
                    case 3:
                        {
                            return 7.5m;
                        }
                    case 4:
                        {
                            return 10m;
                        }
                    default:
                        {
                            return 20m;
                        }
                }
            }
        }

        public decimal PolicyFeeDiscountValue
        {
            get
            {
                return BaseFee * PolicyFeeDiscount / 100;
            }
        }

        public string PolicyHolderName
        {
            get
            {
                return _individualPolicyFee.PolicyHolderName;
            }
        }

        public string PolicyType
        {
            get
            {
                return _individualPolicyFee.PolicyType;
            }
        }

        public decimal BaseFee
        {
            get
            {
                return _individualPolicyFee.Fee * FamilyMembers;
            }
        }
        
        public decimal Fee
        {
            get
            {
                return BaseFee - PolicyFeeDiscountValue;
            }
        }
    }
}
