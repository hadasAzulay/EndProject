import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PricePerOccupantComponent } from './price-per-occupant.component';

describe('PricePerOccupantComponent', () => {
  let component: PricePerOccupantComponent;
  let fixture: ComponentFixture<PricePerOccupantComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PricePerOccupantComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PricePerOccupantComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
