import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProgressScheduleComponent } from './progress-schedule.component';

describe('ProgressScheduleComponent', () => {
  let component: ProgressScheduleComponent;
  let fixture: ComponentFixture<ProgressScheduleComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ProgressScheduleComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ProgressScheduleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
