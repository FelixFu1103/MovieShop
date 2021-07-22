import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { MovieService } from 'src/app/core/services/movie.service';
import { Movie } from 'src/app/shared/models/movie'

@Component({
  selector: 'app-movie-details',
  templateUrl: './movie-details.component.html',
  styleUrls: ['./movie-details.component.css']
})
export class MovieDetailsComponent implements OnInit {
  movie!: Movie;
  id!: number;
  //router to read route information
  constructor(private router: ActivatedRoute, private movieService: MovieService) { }

  //need to get the movie id from url and call the MovieService, getMovieDetails method
  ngOnInit(): void {
    this.router.paramMap.subscribe(
      p => {
        this.id = +p.get('id')!; //+ convert string to number
        console.log(this.id);
        this.movieService.getMovieDetails(this.id)
          .subscribe(m => {
            this.movie = m;
            console.log(this.movie);
          });
      })
  }

}