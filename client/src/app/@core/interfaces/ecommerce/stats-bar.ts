/*
 * Copyright (c) M9 Logistics 2023. All Rights Reserved.
 * Licensed under the Single Application / Multi Application License.
 * See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the 'docs' folder for license information on type of purchased license.
 */

import { Observable } from 'rxjs';
import { AggregatedChartData } from '../common/chart';

export abstract class StatsBarData {
  abstract getStatsBarData(): Observable<AggregatedChartData>;
}
