import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ManagementNoticesComponent } from './management-notices.component';

describe('ManagementNoticesComponent', () => {
  let component: ManagementNoticesComponent;
  let fixture: ComponentFixture<ManagementNoticesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ManagementNoticesComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ManagementNoticesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
