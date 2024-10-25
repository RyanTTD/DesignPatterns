import { IAppliance } from "./IAppliance";

export class Light implements IAppliance
{
    constructor(inputInfo: any) {
        if(inputInfo == null) inputInfo = {};
        
        this.Name = inputInfo.name ?? '';
        this.Type = 'light';
        this.CssClass = inputInfo.cssClass ?? '';
        this.BaseCssClass = 'light';
        this.Active = false;
        this.ImgSrc = '/assets/images/light.png';
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