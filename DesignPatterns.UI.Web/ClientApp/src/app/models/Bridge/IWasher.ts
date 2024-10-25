export interface IWasher {
    StartWashing(): void;
    StopWashing(): void;
    SetDirection(direction: number): void;
}