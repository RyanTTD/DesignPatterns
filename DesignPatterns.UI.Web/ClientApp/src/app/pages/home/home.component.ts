import { Component } from '@angular/core';
import { CoreService } from '../../services/core.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  isHoveringOverHeading: boolean = false;

  constructor(public coreService: CoreService) {

  }

  onMouseOver() {
    this.isHoveringOverHeading = true;
  }

  onMouseOut() {
    this.isHoveringOverHeading = false;
  }

  openCloseMenu() {
    this.coreService.openCloseMenu();
  }
}
