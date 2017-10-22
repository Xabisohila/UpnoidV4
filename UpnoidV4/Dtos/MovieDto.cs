using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UpnoidV4.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public byte GenreId { get; set; }

        public GenreDto Genre { get; set; }
      //  [DataType(DataType.Date)]
        public string DateAdded { get; set; }
       // [DataType(DataType.Date)]
        public string ReleaseDate { get; set; }

        [Range(1, 20)]
        public byte NumberInStock { get; set; }
        public byte NumberAvailable { get; set; }

        public string Description { get; set; }
    }
}