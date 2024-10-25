export interface IPolicyFeeAdapter {
    PolicyHolderName: string;
    PolicyType: string;
    Fee: number;
    BaseFee: number;
    FamilyMembers: number;
    PolicyFeeDiscount: number;
}