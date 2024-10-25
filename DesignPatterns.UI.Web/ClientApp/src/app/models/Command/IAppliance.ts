export interface IAppliance {
    Name: string;
    Type: string;
    CssClass: string;
    BaseCssClass: string;
    Active: boolean;
    ImgSrc: string;

    TurnOn(): void;
    TurnOff(): void;
}