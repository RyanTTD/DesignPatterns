import { IWasher } from "./IWasher";

export abstract class WasherControl 
{
    washer?: IWasher;
    
    constructor(
        public inputWasher: IWasher
      ) {
        this.washer = inputWasher;
    }

    abstract StartStopWashing(): void;
    abstract SetDirection(direction: number): void;
}