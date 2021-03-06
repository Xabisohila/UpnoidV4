﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using UpnoidV4.Models;

namespace UpnoidV4.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
              public int? Id { get; set; }
              [Required]
              [StringLength(255)]
              public string Name { get; set; }
              [Display(Name = "Genre")]
              [Required]
              public byte? GenreId { get; set; }
              [Required]
              [Display(Name="Release Date")]
              public string ReleaseDate { get; set; }
              //public DateTime? ReleaseDate { get; set; }
              [Display(Name = "Number in Stock")]
              [Range(1,20)]
              [Required]
              public byte? NumberInStock { get; set; }

       
              public byte NumberAvailable { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 7)]
        public string Description { get; set; }


        public string Title
              {
                  get
                  {
                      return Id != 0? "Edit Movie" : "New Movie";
                  }
              }

              public MovieFormViewModel()
              {
                  Id = 0;
              }

              public MovieFormViewModel(Movie movie)
              {
                  Id = movie.Id;
                  Name = movie.Name;
                  ReleaseDate = movie.ReleaseDate;
                  NumberInStock = movie.NumberInStock;
                  GenreId = movie.GenreId;
              }
    }
   
}