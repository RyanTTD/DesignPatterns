import { IAppliance } from "./IAppliance";

export class Fan implements IAppliance
{
    constructor(inputInfo: any) {
        if(inputInfo == null) inputInfo = {};
        
        this.Name = inputInfo.name ?? '';
        this.Type = 'fan';
        this.CssClass = inputInfo.cssClass ?? '';
        this.BaseCssClass = 'fan';
        this.Active = false;
        this.ImgSrc = '/assets/images/fan.png';
    }

    Name: string;
    Type: string;
    CssClass: string;
    BaseCssClass: string;
    Active: boolean;
    ImgSrc: string;

    TurnOn(): void {
        this.Active = true;
    }

    TurnOff(): void {
        this.Active = false;
    }
}