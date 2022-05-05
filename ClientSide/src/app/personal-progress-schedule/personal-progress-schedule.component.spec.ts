import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PersonalProgressScheduleComponent } from './personal-progress-schedule.component';

describe('PersonalProgressScheduleComponent', () => {
  let component: PersonalProgressScheduleComponent;
  let fixture: ComponentFixture<PersonalProgressScheduleComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PersonalProgressScheduleComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PersonalProgressScheduleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
