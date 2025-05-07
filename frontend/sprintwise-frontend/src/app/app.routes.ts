import { Routes } from '@angular/router';

import { LayoutComponent } from './layout/layout.component';

export const routes: Routes = [
  {
    path: '',
    component: LayoutComponent,
    children: [
      {
        path: '',
        redirectTo: 'dashboard',
        pathMatch: 'full'
      },
      {
        path: 'dashboard',
        loadChildren: () =>
          import('./components/dashboard/dashboard.routes').then((m) => m.DASHBOARD_ROUTES)
      }
    ]
  }
];

export default routes;