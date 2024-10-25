import { Component } from '@angular/core';
import { CoreService } from '../services/core.service';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent {
  isExpanded = false;

  constructor(public coreService: CoreService) {
  }

  collapse() {
    this.coreService.openCloseMenu();
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }
}
