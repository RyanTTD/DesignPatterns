import { IPatron } from "./IPatron";
import { PatronDecorator } from "./Patron.Decorator";

export class IceCreamDecorator extends PatronDecorator
{
    constructor(public inputPatron: IPatron) {
        super(inputPatron);
    }

    GetName() {
        return super.GetName();
    };
    
    GetOrder(){
        return super.GetOrder() + "ice-cream ";
    };

    GetCost(){
        return super.GetCost() + 21;
    };

    GetDiscount(){
        return super.GetDiscount();
    };
}