import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NameInputComponent } from './name-input.component';

describe('NameInputComponent', () => {
  let component: NameInputComponent;
  let fixture: ComponentFixture<NameInputComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [NameInputComponent]
    });
    fixture = TestBed.createComponent(NameInputComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
