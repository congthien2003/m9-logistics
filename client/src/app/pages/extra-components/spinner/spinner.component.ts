/*
 * Copyright (c) M9 Logistics 2023. All Rights Reserved.
 * Licensed under the Single Application / Multi Application License.
 * See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the 'docs' folder for license information on type of purchased license.
 */

import { Component } from '@angular/core';

@Component({
  selector: 'ngx-spinner',
  templateUrl: 'spinner.component.html',
  styleUrls: ['spinner.component.scss'],
})

export class SpinnerComponent {

  loading = false;

  toggleLoadingAnimation() {
    this.loading = true;
    setTimeout(() => this.loading = false, 3000);
  }
}
