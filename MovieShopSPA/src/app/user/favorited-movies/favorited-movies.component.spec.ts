import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FavoritedMoviesComponent } from './favorited-movies.component';

describe('FavoritedMoviesComponent', () => {
  let component: FavoritedMoviesComponent;
  let fixture: ComponentFixture<FavoritedMoviesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FavoritedMoviesComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(FavoritedMoviesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
