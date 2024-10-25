import { Component } from '@angular/core';
import { CoreService } from '../../../../services/core.service';
import { PolicyFee } from 'src/app/models/Adapter/PolicyFee';
import { PolicyFeeAdapter } from 'src/app/models/Adapter/PolicyFeeAdapter';

@Component({
  selector: 'app-adapter',
  templateUrl: './adapter.component.html',
})
export class AdapterComponent {
  isHoveringOverHeading: boolean = false;
  availablePolicies: any[] = [];
  selectedPolicy: any = null;
  policyHolderName: string = '';
  policyQuotes: any[] = [];

  constructor(public coreService: CoreService) {
    this.housekeeping();
  }

  housekeeping() {
    this.populateAvaialblePolicies();
  }

  getPolicyInformation() {
    var self = this;

    var policyFee = new PolicyFee(self.policyHolderName, self.selectedPolicy.policyType, self.selectedPolicy.fee);

    self.policyQuotes = [];

    for(var count = 2; count < 7; count++) {
      self.policyQuotes.push(new PolicyFeeAdapter(policyFee, count));
    }
  }

  populateAvaialblePolicies() {
    this.availablePolicies = [];

    this.availablePolicies.push({
      policyType: 'Hospital Plan',
      fee: 200
    });
    this.availablePolicies.push({
      policyType: 'Medical Aid',
      fee: 500
    });
    this.availablePolicies.push({
      policyType: 'Medical Aid with Savings',
      fee: 750
    });
    this.availablePolicies.push({
      policyType: 'Gap Cover',
      fee: 150
    });

    this.selectedPolicy = this.availablePolicies[0];
  }
}
