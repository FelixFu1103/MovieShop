import {Cast} from './cast';
import { Genre } from './genre';
export interface MovieDetail {
    id: number;
    title: string;
    overview: string;
    tagline: string;
    budget: number;
    revenue: number;
    imdbUrl: string;
    posterUrl: string;
    backdropUrl: string;
    originalLanguage: string;
    releaseDate: Date;
    runTime: number;
    price: number;
    createdDate?: any;
    updatedDate?: any;
    updatedBy?: any;
    createdBy?: any;
    rating: number;
    casts: Cast[];
    genres: Genre[];

}