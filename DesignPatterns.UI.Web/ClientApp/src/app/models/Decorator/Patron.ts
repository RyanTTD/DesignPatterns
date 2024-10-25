import { IPatron } from "./IPatron";
import { PatronDecorator } from "./Patron.Decorator";

export class Patron implements IPatron
{
    constructor(public inputName: string) {
        this.name = inputName;
    }

    name: string = '';

    GetName() {
        return this.name;
    };
    
    GetOrder(){
        return "";
    };

    GetCost(){
        return 0;
    };

    GetDiscount(){
        return 0;
    };
}