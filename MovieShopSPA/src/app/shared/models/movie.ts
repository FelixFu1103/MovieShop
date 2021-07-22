export interface Cast {
    id: number;
    name: string;
    gender?: any;
    tmdbUrl?: any;
    profilePath: string;
    character: string;
}

export interface Genre {
    id: number;
    name: string;
    movies?: any;
}

export interface Movie {
    id: number;
    title: string;
    posterUrl: string;
    backdropUrl: string;
    rating: number;
    overview: string;
    tagline: string;
    budget: number;
    revenue: number;
    imdbUrl: string;
    tmdbUrl: string;
    releaseDate: Date;
    runTime: number;
    price: number;
    favoritesCount: number;
    casts: Cast[];
    genres: Genre[];
}
