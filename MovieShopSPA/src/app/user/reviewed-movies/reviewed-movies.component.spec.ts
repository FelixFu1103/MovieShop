import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ReviewedMoviesComponent } from './reviewed-movies.component';

describe('ReviewedMoviesComponent', () => {
  let component: ReviewedMoviesComponent;
  let fixture: ComponentFixture<ReviewedMoviesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ReviewedMoviesComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ReviewedMoviesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
