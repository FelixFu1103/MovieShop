  
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { environment } from 'src/environments/environment';
import { MovieCard } from 'src/app/shared/models/movie-card';
import { Movie } from 'src/app/shared/models/movie';

@Injectable({
  providedIn: 'root'
})
export class MovieService {

  constructor(private http: HttpClient) { }

  getTopRevenueMovies(): Observable<MovieCard[]> { //after : is return type
    //make an ajax http call to api https://localhost:44333/api/Movies/toprevenue
    return this.http.get(`${environment.apiUrl}` + 'Movies/toprevenue')
      //domain name is common, so no need for hard code whole url
      .pipe(map(resp => resp as MovieCard[]));
    //map json array to moviecard

  }

  getMovieDetails(id: number): Observable<Movie> {
    return this.http.get(`${environment.apiUrl}` + 'Movies/' + id).pipe(map(resp => resp as Movie));
  }
}
    //angular use observable
/*Youtube, channels user can subscribe
channel => upload a new video => user => subscribe to that channel, you can receive notification
similiar in Tech, Publish/Subscribe =>
Observer pattern
In c#, async programming, using async/await, return type task => promise
In JS, async programming, (make Http Call, Ajax call), using Promises
In older version of angular js, use Promise
in new angular, => google suggest Observable =>use Rxjs => Linq Methods =>
in angular, sue HttpClient, coming from HttpModules, observable
//in httpclient, you ccan use a series of operations to transfrom values as needed
similar to linq,var list => empllist.where(e =>e.salary>2000).take(20).Tolist()
only when tolist/ count.... is called, value is put in var list
In observable, only subscribe(), then you can get value
lazy collection over time
to use thse operators, need to put it into pipe
filter ***need to check the rahx website
*/