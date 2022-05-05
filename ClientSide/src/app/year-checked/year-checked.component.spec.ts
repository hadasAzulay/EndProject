import { ComponentFixture, TestBed } from '@angular/core/testing';

import { YearCheckedComponent } from './year-checked.component';

describe('YearCheckedComponent', () => {
  let component: YearCheckedComponent;
  let fixture: ComponentFixture<YearCheckedComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ YearCheckedComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(YearCheckedComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
