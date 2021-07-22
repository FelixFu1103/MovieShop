
import { Component, OnInit } from '@angular/core';
import { MovieService } from '../core/services/movie.service';
// import { MovieCard } from '../shared/models/moviecard';
import { MovieCard } from '../shared/models/movie-card';


@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  constructor(private movieService: MovieService) { }

  movies!: MovieCard[];
  // Born, School, Married...death
  // Angular Life Cycle Hooks
  ngOnInit(): void {

    // call our service
    this.movieService.getTopRevenueMovies().subscribe(

      m => {
        this.movies = m;
        console.log('inside Home Component');
        //console.log(this.movies);
        console.table(this.movies);
      }

    );
  }

}