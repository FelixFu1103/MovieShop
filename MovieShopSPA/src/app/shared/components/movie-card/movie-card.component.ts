import { Component, Input, OnInit } from '@angular/core';
import { MovieCard } from '../../models/movie-card';

@Component({
  selector: 'app-movie-card',
  templateUrl: './movie-card.component.html',
  styleUrls: ['./movie-card.component.css']
})
export class MovieCardComponent implements OnInit {


  @Input()
  moviecard!: MovieCard;

  constructor() { }

  ngOnInit(): void {

    console.log(this.moviecard);
  }

}