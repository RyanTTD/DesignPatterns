export class PolicyFee
{
    constructor(policyHolderName: string, policyType: string, fee: number) {
        this.PolicyHolderName = policyHolderName;
        this.PolicyType = policyType;
        this.Fee = fee;
    }
    PolicyHolderName: string = '';
    PolicyType: string = '';
    Fee: number = 0;
}