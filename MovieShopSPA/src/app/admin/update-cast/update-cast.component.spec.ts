import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UpdateCastComponent } from './update-cast.component';

describe('UpdateCastComponent', () => {
  let component: UpdateCastComponent;
  let fixture: ComponentFixture<UpdateCastComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UpdateCastComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(UpdateCastComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
