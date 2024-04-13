import {
  Component,
  OnDestroy,
  OnInit,
  OnChanges,
  SimpleChanges,
  Input,
  Output,
  EventEmitter,
} from '@angular/core';

@Component({
  selector: 'app-name-input',
  templateUrl: './name-input.component.html',
  styleUrls: ['./name-input.component.css'],
})
export class NameInputComponent implements OnDestroy, OnInit, OnChanges {
  @Input() inputValue = 'Default Value';
  @Output() btnClick = new EventEmitter();

  constructor() {
    console.log('ctor');
  }

  // inputKeyupHandler(event: KeyboardEvent): void {
  //     // console.log(event);

  //     this.inputValue = (event.target as HTMLInputElement).value;
  // }

  btnClickHandler(value: MouseEvent, inputEl: HTMLInputElement): void {
    console.log('Button was clicked!', value);

    this.btnClick.emit({ inputEl });
  }

  ngOnDestroy(): void {
    console.log('Name input component was destroyed.');
  }

  ngOnInit(): void {}

  ngOnChanges(simpleChanges: SimpleChanges): void {
    console.log(simpleChanges);
  }
}
