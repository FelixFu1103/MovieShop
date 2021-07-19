﻿using ApplicationCore.Entities;
using ApplicationCore.RepositoryInterfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class GenreRepository : EfRepository<Genre>, IGenreRepository
    {
        public GenreRepository(MovieShopDbContext dbContext) : base(dbContext) { }

        public override async Task<Genre> GetByIdAsync(int id)
        {
            var genre = await _dbContext
                .Genres.Include(g => g.Movies).FirstOrDefaultAsync(g => g.Id == id);

            if (genre == null)
            {
                throw new Exception($"No Genre Found with {id}");
            }

            return genre;
        }

    }
}
