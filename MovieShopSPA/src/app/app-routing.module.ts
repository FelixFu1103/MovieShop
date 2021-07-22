
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CreateCastComponent } from './admin/create-cast/create-cast.component';
import { CreateMovieComponent } from './admin/create-movie/create-movie.component';
import { LoginComponent } from './auth/login/login.component';
import { RegisterComponent } from './auth/register/register.component';
import { HomeComponent } from './home/home.component';
import { MovieDetailsComponent } from './movies/movie-details/movie-details.component';


const routes: Routes = [
  {path: "", component: HomeComponent},
  {path: "login", component: LoginComponent},
  {path: "register", component: RegisterComponent},
  { path: "admin/createmovie", component: CreateMovieComponent },
  { path: "admin/createcast", component: CreateCastComponent },
  { path: "movies/details/:id", component: MovieDetailsComponent }

];
@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
