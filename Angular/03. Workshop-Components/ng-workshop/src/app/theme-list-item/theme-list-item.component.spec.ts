import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ThemeListItemComponent } from './theme-list-item.component';

describe('ThemeListItemComponent', () => {
  let component: ThemeListItemComponent;
  let fixture: ComponentFixture<ThemeListItemComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ThemeListItemComponent]
    });
    fixture = TestBed.createComponent(ThemeListItemComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
