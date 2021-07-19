using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models
{
    public class GenreDetailsResponseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<MovieCardResponseModel> Movies { get; set; }
    }
}