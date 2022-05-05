import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListOfTenantsComponent } from './list-of-tenants.component';

describe('ListOfTenantsComponent', () => {
  let component: ListOfTenantsComponent;
  let fixture: ComponentFixture<ListOfTenantsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ListOfTenantsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ListOfTenantsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
