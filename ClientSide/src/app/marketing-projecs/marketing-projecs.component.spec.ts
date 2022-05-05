import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MarketingProjecsComponent } from './marketing-projecs.component';

describe('MarketingProjecsComponent', () => {
  let component: MarketingProjecsComponent;
  let fixture: ComponentFixture<MarketingProjecsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MarketingProjecsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(MarketingProjecsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
