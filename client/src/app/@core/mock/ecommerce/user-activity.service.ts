/*
 * Copyright (c) M9 Logistics 2023. All Rights Reserved.
 * Licensed under the Single Application / Multi Application License.
 * See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the 'docs' folder for license information on type of purchased license.
 */

import { Injectable } from '@angular/core';
import { of as observableOf,  Observable } from 'rxjs';
import { PeriodsService } from '../common/periods.service';
import { UserActive, UserActivityData } from '../../interfaces/ecommerce/user-activity';

@Injectable()
export class UserActivityService extends UserActivityData {

  private getRandom = (roundTo: number) => Math.round(Math.random() * roundTo);
  private generateUserActivityRandomData(date) {
    return {
      date,
      pagesVisitCount: this.getRandom(1000),
      deltaUp: this.getRandom(1) % 2 === 0,
      newVisits: this.getRandom(100),
    };
  }

  data = {};

  constructor(private periods: PeriodsService) {
    super();
    this.data = {
      week: this.getDataWeek(),
      month: this.getDataMonth(),
      year: this.getDataYear(),
    };
  }

  private getDataWeek(): UserActive[] {
    return this.periods.getWeeks().map((week) => {
      return this.generateUserActivityRandomData(week);
    });
  }

  private getDataMonth(): UserActive[] {
    const currentDate = new Date();
    const days = currentDate.getDate();
    const month = this.periods.getMonths()[currentDate.getMonth()];

    return Array.from(Array(days)).map((_, index) => {
      const date = `${index + 1} ${month}`;

      return this.generateUserActivityRandomData(date);
    });
  }

  private getDataYear(): UserActive[] {
    return this.periods.getYears().map((year) => {
      return this.generateUserActivityRandomData(year);
    });
  }

  getUserActivityData(period: string): Observable<UserActive[]> {
    return observableOf(this.data[period]);
  }
}
