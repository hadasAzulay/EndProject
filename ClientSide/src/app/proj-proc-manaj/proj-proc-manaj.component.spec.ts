import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProjProcManajComponent } from './proj-proc-manaj.component';

describe('ProjProcManajComponent', () => {
  let component: ProjProcManajComponent;
  let fixture: ComponentFixture<ProjProcManajComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ProjProcManajComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ProjProcManajComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
