import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PopulatedProjecsComponent } from './populated-projecs.component';

describe('PopulatedProjecsComponent', () => {
  let component: PopulatedProjecsComponent;
  let fixture: ComponentFixture<PopulatedProjecsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PopulatedProjecsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PopulatedProjecsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
