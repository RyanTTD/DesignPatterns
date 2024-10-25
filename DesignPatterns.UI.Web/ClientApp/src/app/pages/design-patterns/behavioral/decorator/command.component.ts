import { Component } from '@angular/core';
import { CoreService } from '../../../../services/core.service';
import { BurgerDecorator } from 'src/app/models/Decorator/Burger.Decorator';
import { CookieDecorator } from 'src/app/models/Decorator/Cookie.Decorator';
import { IceCreamDecorator } from 'src/app/models/Decorator/IceCream.Decorator';
import { CoffeeDecorator } from 'src/app/models/Decorator/Cofee.Decorator';
import { Patron } from 'src/app/models/Decorator/Patron';
import { DiscountDecorator } from 'src/app/models/Decorator/Discount.Decorator';
import { Light } from 'src/app/models/Command/Light';
import { Fan } from 'src/app/models/Command/Fan';
import { IAppliance } from 'src/app/models/Command/IAppliance';
import { CommandController } from 'src/app/models/Command/CommandController';

@Component({
  selector: 'app-command',
  templateUrl: './command.component.html',
})
export class CommandComponent {
  appliances: IAppliance[] = [];

  constructor(public coreService: CoreService) {
    this.addLight();
    this.addFan();
  }

  addLight() {
    var light = new Light ({
      name: 'Kitchen Light',
      cssClass: 'yellow'
    });
    this.appliances.push(light);
  }

  addFan() {
    var fan = new Fan({
      name: 'Lounge Fan',
      cssClass: 'rotating-div'
    });
    this.appliances.push(fan);
  }

  turnAllOn() {
    this.appliances.forEach((light: any) => {
      this.turnItemOn(light);
    });
  }

  turnAllOff() {
    this.appliances.forEach((appliance: any) => {
      this.turnItemOff(appliance);
    });
  }

  turnItemOn(appliance: IAppliance) {
    var command = new CommandController(appliance);
    command.Execute();
  }

  turnItemOff(appliance: IAppliance) {
    var command = new CommandController(appliance);
    command.Undo();
  }
}
