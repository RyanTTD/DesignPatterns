import { IAppliance } from "./IAppliance";
import { ICommand } from "./ICommand";
import { Light } from "./Light";

export class CommandController implements ICommand
{
    appliance: IAppliance;

    constructor(inputAppliance: IAppliance)
    {
        this.appliance = inputAppliance;
    }   

    Execute(): void {
        this.appliance.TurnOn();
        console.log(this.appliance.Name + " execute hit.");
    }
    
    Undo(): void {
        this.appliance.TurnOff();
        console.log(this.appliance.Name + " undo hit.");
    }
}