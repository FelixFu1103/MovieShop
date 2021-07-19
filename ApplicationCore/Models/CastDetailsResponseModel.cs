using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public class CastDetailsResponseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string TmdbUrl { get; set; }
        public string ProfilePath { get; set; }
        public List<MovieCardResponseModel> Movies { get; set; }
    }
}
