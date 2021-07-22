import { Injectable } from '@angular/core';
import { MovieCard } from 'src/app/shared/models/moviecard';

@Injectable({
  providedIn: 'root',
})
export class MovieService {
  constructor() {}
  getTopRevenueMovies(): Array<MovieCard> {
    var movies = fetch('https://localhost:5001/api/Movies/toprevenue')
      .then((res) => {
        return res.json;
      })
      .catch((err) => null);

    return movies;
  }
}