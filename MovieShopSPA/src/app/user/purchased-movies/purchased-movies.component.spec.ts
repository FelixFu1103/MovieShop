import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PurchasedMoviesComponent } from './purchased-movies.component';

describe('PurchasedMoviesComponent', () => {
  let component: PurchasedMoviesComponent;
  let fixture: ComponentFixture<PurchasedMoviesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PurchasedMoviesComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PurchasedMoviesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
