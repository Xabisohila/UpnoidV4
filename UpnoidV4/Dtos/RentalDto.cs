using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using UpnoidV4.Models;

namespace UpnoidV4.Dtos
{
    public class RentalDto
    {
        public int Id { get; set; }

        [Required]
        public Customer Customer { get; set; }

        [Required]
        public Movie Movie { get; set; }

        public string DateRented { get; set; }

        public DateTime? DateReturned { get; set; }
    }
}