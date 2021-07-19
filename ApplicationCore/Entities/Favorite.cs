﻿using System;
namespace ApplicationCore.Entities
{
    public class Favorite
    {
        public int UserId { get; set; }
        public int MovieId { get; set; }

        public Movie Movie { get; set; }
        public User User { get; set; }
    }
}
