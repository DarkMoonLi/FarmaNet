import { ComponentFixture, TestBed } from '@angular/core/testing';

import { WritedownComponent } from './writedown.component';

describe('WritedownComponent', () => {
  let component: WritedownComponent;
  let fixture: ComponentFixture<WritedownComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ WritedownComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(WritedownComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
