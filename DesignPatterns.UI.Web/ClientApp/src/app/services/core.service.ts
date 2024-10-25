import { Injectable } from "@angular/core";

@Injectable({
  providedIn: 'root'
})
export class CoreService {
  menuOpen: boolean = false;
  constructor() {
    const self = this;
  }

  openCloseMenu() {
    if(this.menuOpen == true) {
      window.scroll({ 
        top: 0, 
        left: 0, 
        behavior: 'smooth' 
      });
    }

    this.menuOpen = !this.menuOpen;
  }

  scrollToStart() {
    this.scrollToElement('page-start');
  }

  scrollToNerds() {
    this.scrollToElement('nerds');
  }

  scrollToNotSoNerds() {
    this.scrollToElement('not-so-nerds');
  }

  scrollToExample() {
    this.scrollToElement('example');
  }

  scrollToElement(elemntId: string) {
    const element = document.getElementById(elemntId);
    if(element != null) {
      const offsetTop = element?.offsetTop;

      window.scroll({
          top: offsetTop, 
          left: 0, 
          behavior: 'smooth'
      });
    }
  }
}
