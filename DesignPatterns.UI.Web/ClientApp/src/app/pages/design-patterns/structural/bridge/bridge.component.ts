import { Component } from '@angular/core';
import { CoreService } from '../../../../services/core.service';
import { WindowWasher } from 'src/app/models/Bridge/WindowWasher';
import { MobileWasher } from 'src/app/models/Bridge/MobileWasher';

@Component({
  selector: 'app-bridge',
  templateUrl: './bridge.component.html',
})
export class BridgeComponent {
  washer?: WindowWasher;
  mobileWasher?: MobileWasher;

  constructor(public coreService: CoreService) {
    this.washer = new WindowWasher();
    this.mobileWasher = new MobileWasher(this.washer);
  }
}
