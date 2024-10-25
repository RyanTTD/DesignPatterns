import { IPatron } from "./IPatron";
import { PatronDecorator } from "./Patron.Decorator";

export class BurgerDecorator extends PatronDecorator
{
    constructor(public inputPatron: IPatron) {
        super(inputPatron);
    }

    GetName() {
        return super.GetName();
    };
    
    GetOrder(){
        return super.GetOrder() + "burger ";
    };

    GetCost(){
        return super.GetCost() + 50;
    };

    GetDiscount(){
        return super.GetDiscount();
    };
}