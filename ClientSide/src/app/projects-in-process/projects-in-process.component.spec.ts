import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProjectsInProcessComponent } from './projects-in-process.component';

describe('ProjectsInProcessComponent', () => {
  let component: ProjectsInProcessComponent;
  let fixture: ComponentFixture<ProjectsInProcessComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ProjectsInProcessComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ProjectsInProcessComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
