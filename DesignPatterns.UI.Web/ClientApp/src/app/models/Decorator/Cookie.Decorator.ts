import { IPatron } from "./IPatron";
import { PatronDecorator } from "./Patron.Decorator";

export class CookieDecorator extends PatronDecorator
{
    constructor(public inputPatron: IPatron) {
        super(inputPatron);
    }

    GetName() {
        return super.GetName();
    };
    
    GetOrder(){
        return super.GetOrder() + "cookie ";
    };

    GetCost(){
        return super.GetCost() + 12;
    };

    GetDiscount(){
        return super.GetDiscount();
    };
}