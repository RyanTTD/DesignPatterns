import { IPatron } from "./IPatron";
import { PatronDecorator } from "./Patron.Decorator";

export class DiscountDecorator extends PatronDecorator
{
    constructor(public inputPatron: IPatron) {
        super(inputPatron);
    }

    GetName() {
        return super.GetName();
    };
    
    GetOrder(){
        return super.GetOrder();
    };

    GetCost(){
        return (super.GetCost() * 90/100);
    };

    GetDiscount(){
        return (super.GetDiscount()) + (super.GetCost() * 10/100);
    };
}