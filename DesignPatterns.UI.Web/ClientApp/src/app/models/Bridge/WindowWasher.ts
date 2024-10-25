import { IWasher } from "./IWasher";

export class WindowWasher implements  IWasher
{
    direction: number = 1;
    position: number = -5;
    minPosition: number = -5;
    maxPosition: number = 105;
    washInterval: any;

    StartWashing(): void {
        var self = this;

        if(this.washInterval != null) this.StopWashing();

        this.washInterval = setInterval(function() {
            if(self.position == self.maxPosition && self.direction == 1) {
                self.StopWashing();
                return;
            }
            if(self.position == self.minPosition && self.direction == -1) {
                self.StopWashing();
                return;
            }

            self.position += self.direction;
        }, 25);
    }
    StopWashing(): void {
        clearInterval(this.washInterval);
    }
    SetDirection(direction: number): void {
        this.direction = direction;
    }
}