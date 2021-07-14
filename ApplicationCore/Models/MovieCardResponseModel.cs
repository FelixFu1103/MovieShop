using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public class MovieCardResponseModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string PosterUrl { get; set; }
        public decimal Budget { get; set; }

        
    }
}
