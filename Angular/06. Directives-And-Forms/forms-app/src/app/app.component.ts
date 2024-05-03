import { Component, ViewChild } from '@angular/core';
import { HighlightDirective } from './shared/highlight.directive';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  // title = 'forms-app';
  //  hasMyClass = true;

  @ViewChild('paragraphHighlight', { static: false }) pDirective: HighlightDirective;

  users = [
    {
      name: 'Ivan',
      age: 20
    },
    {
      name: 'Peter',
      age: 30
    },
  ];

  isHighlighted = false;

  toggleHighlightHandler(p: HighlightDirective) {
    this.isHighlighted = !this.isHighlighted;
    // p.onMouseEnter(null as any);
    console.log(p);
  }

  ngAfterViewInit(): void {
    console.log(this.pDirective);
  }
}
