import { ComponentFixture, TestBed } from '@angular/core/testing';

import { WritedownsComponent } from './writedowns.component';

describe('WritedownsComponent', () => {
  let component: WritedownsComponent;
  let fixture: ComponentFixture<WritedownsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ WritedownsComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(WritedownsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
