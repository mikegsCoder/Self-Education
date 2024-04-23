import { Component, Input } from '@angular/core';
import { ITheme } from '../interfaces';

@Component({
  selector: 'app-theme-list-item',
  templateUrl: './theme-list-item.component.html',
  styleUrls: ['./theme-list-item.component.css'],
})
export class ThemeListItemComponent {
  @Input() theme: ITheme;

  constructor() {}
}
