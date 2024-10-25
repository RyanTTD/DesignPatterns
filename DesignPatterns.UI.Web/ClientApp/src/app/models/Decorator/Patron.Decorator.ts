import { IPatron } from "./IPatron";

export abstract class PatronDecorator  implements IPatron
{
    protected patron: IPatron;
    
    constructor(
        public inputPatron: IPatron
      ) {
        this.patron = inputPatron;
    }

    GetName() {
        return this.patron.GetName();
    };
    
    GetOrder(){
        return this.patron.GetOrder();
    };

    GetCost(){
        return this.patron.GetCost();
    };

    GetDiscount(){
        return this.patron.GetDiscount();
    };
}