import { Component } from '@angular/core';
import { UserCardComponent } from './user-card/user-card.component';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-planning-poker',
  imports: [UserCardComponent, CommonModule],
  templateUrl: './planning-poker.component.html',
  styleUrl: './planning-poker.component.scss'
})

export class PlanningPokerComponent {
  public leftUsers: any = [
    {name: 'juan', status: 'Votando...'},
    {name: 'Hipolito', status: 'Votando...'},
    {name: 'Arthur', status: 'Votando...'}

  ]
  public bottomUsers: any = [
    {name: 'Lucas', status: 'Votando...'},
    {name: 'Breno', status: 'Votando...'},
    {name: 'Rafael', status: 'Votando...'}
  ]
  public rightUsers: any = [{name: 'juan', status: 'Votando...'}]
  public cards = ['1', '2', '3', '5', '8', '13', '21', '34', '?'];
}
