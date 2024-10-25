import { IPatron } from "./IPatron";
import { PatronDecorator } from "./Patron.Decorator";

export class CoffeeDecorator extends PatronDecorator
{
    constructor(public inputPatron: IPatron) {
        super(inputPatron);
    }

    GetName() {
        return super.GetName();
    };
    
    GetOrder(){
        return super.GetOrder() + "mug-hot ";
    };

    GetCost(){
        return super.GetCost() + 35;
    };

    GetDiscount(){
        return super.GetDiscount();
    };
}