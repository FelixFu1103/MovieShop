using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using ApplicationCore.Models;

namespace ApplicationCore.Entities
{
    [Table("Genre")]
    public class Genre
    {
        public int Id { get; set; }

        [MaxLength(24)]
        public string Name { get; set; }

        public ICollection<Movie> Movies { get; set; }
    }

    // To change entity/table 2 optionns, DataAnnotation, Fluennt API
}
