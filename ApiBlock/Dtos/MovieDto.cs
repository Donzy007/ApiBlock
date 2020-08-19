using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ApiBlock.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }


        [Required]
        public byte GenreId { get; set; }

        public DateTime DateAdded { get; set; }
        
        public DateTime ReleaseDate { get; set; }

        
        public byte NumberInStock { get; set; }
    }
}