import { IWasher } from "./IWasher";
import { WasherControl } from "./WasherControl";

export class MobileWasher extends WasherControl
{
    washer?: IWasher | undefined;
    isWashing: boolean = false;
    direction: number = 1;

    constructor(inputWasher: IWasher) {
        super(inputWasher);
    }

    StartStopWashing(): void {
        if(this.isWashing) {
            this.washer?.StopWashing();
        }
        else {
            this.washer?.StartWashing();
        }

        this.isWashing = !this.isWashing;
    }

    SetDirection(direction: number): void {
        this.washer?.SetDirection(direction);
        this.direction = direction;
    }
}