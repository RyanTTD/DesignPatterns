import { IPolicyFeeAdapter } from "./IPolicyFeeAdapter";
import { PolicyFee } from "./PolicyFee";

export class PolicyFeeAdapter implements IPolicyFeeAdapter
{
    private policyFee: PolicyFee;

    constructor(inputPolicy: PolicyFee, familyMembers: number) {
        this.policyFee = inputPolicy;

        this.PolicyHolderName = this.policyFee.PolicyHolderName;
        this.PolicyType = this.policyFee.PolicyType;
        this.BaseFee = this.policyFee.Fee;

        if(familyMembers < 1) familyMembers = 1;
        this.FamilyMembers = familyMembers;

        this.PolicyFeeDiscount = this.calculateDiscount();
        this.Fee = this.calculateFee();
    }

    PolicyHolderName: string = '';
    PolicyType: string = '';
    BaseFee: number = 0;

    FamilyMembers: number = 0;
    PolicyFeeDiscount: number = 0;

    Fee: number = 0;

    private calculateDiscount() {
        if(this.FamilyMembers < 2) return 0;

        switch(this.FamilyMembers) {
            case 2:
                {
                    return 5;
                }
            case 3:
                {
                    return 7.5;
                }
            case 4:
                {
                    return 10;
                }
            case 5:
                {
                    return 12.5;
                }
            default:
                {
                    return 15;
                }
        }
    }

    private calculateFee() {
        return (this.BaseFee * this.FamilyMembers) * (100 - this.PolicyFeeDiscount) / 100;
    }
}