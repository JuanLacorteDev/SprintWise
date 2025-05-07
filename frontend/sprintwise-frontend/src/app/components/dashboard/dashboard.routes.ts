import { Routes } from '@angular/router';
import { DashboardComponent } from './dashboard.component';
import { PlanningPokerComponent } from '../planning-poker/planning-poker.component';

export const DASHBOARD_ROUTES: Routes = [
  {
    path: '',
    component: PlanningPokerComponent
  }
];