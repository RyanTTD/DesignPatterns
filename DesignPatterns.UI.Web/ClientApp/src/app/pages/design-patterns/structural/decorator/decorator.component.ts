import { Component } from '@angular/core';
import { CoreService } from '../../../../services/core.service';
import { BurgerDecorator } from 'src/app/models/Decorator/Burger.Decorator';
import { CookieDecorator } from 'src/app/models/Decorator/Cookie.Decorator';
import { IceCreamDecorator } from 'src/app/models/Decorator/IceCream.Decorator';
import { CoffeeDecorator } from 'src/app/models/Decorator/Cofee.Decorator';
import { Patron } from 'src/app/models/Decorator/Patron';
import { DiscountDecorator } from 'src/app/models/Decorator/Discount.Decorator';

@Component({
  selector: 'app-decorator',
  templateUrl: './decorator.component.html',
})
export class DecoratorComponent {
  selectedPatron: any;
  patrons: any[] = [];
  totalSales: number = 0;
  totalDiscount: number = 0;

  constructor(public coreService: CoreService) {
    this.addPatron();
  }

  addPatron() {
    this.selectedPatron = new Patron("Patron " + (this.patrons.length + 1));
  }

  addBurger() {
    this.selectedPatron = new BurgerDecorator(this.selectedPatron);
  }

  addCookie() {
    this.selectedPatron = new CookieDecorator(this.selectedPatron);
  }

  addIceCream() {
    this.selectedPatron = new IceCreamDecorator(this.selectedPatron);
  }

  addCoffee() {
    this.selectedPatron = new CoffeeDecorator(this.selectedPatron);
  }

  addDiscount() {
    this.selectedPatron = new DiscountDecorator(this.selectedPatron);
  }

  savePatron() {
    if(this.selectedPatron.GetCost() == 0) return;
    
    this.patrons.push(this.selectedPatron);

    this.totalSales = this.patrons.reduce((sum, item) => sum + item.GetCost(), 0);
    this.totalDiscount = this.patrons.reduce((sum, item) => sum + item.GetDiscount(), 0);

    this.selectedPatron = new Patron("Patron " + (this.patrons.length + 1));
  }
}
