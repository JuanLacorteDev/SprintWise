import { Component, OnInit } from '@angular/core';
import { MenuItem } from 'primeng/api';
import { PanelMenuModule } from 'primeng/panelmenu';

@Component({
  selector: 'app-sidebar',
  imports: [PanelMenuModule],
  templateUrl: './sidebar.component.html',
  styleUrl: '../layout.component.scss'
})

export class SidebarComponent implements OnInit {
  itemsPrincipal: MenuItem[] = [];
  itemsAnalise: MenuItem[] = [];

  ngOnInit() {
    this.itemsPrincipal = [
      {
        label: 'Dashboard',
        icon: 'pi pi-home',
        routerLink: '/dashboard',
      },
      {
        label: 'Usuários',
        icon: 'pi pi-users',
        routerLink: '/usuarios',
      },
    ];

    this.itemsAnalise = [
      {
        label: 'Relatórios',
        icon: 'pi pi-home',
        routerLink: '/dashboard',
      },
      {
        label: 'Gráficos',
        icon: 'pi pi-users',
        routerLink: '/usuarios',
      },
    ];
  }
}
