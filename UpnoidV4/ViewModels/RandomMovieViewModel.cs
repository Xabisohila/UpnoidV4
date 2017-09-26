using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UpnoidV4.Models;

namespace UpnoidV4.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }

        public List<Customer> Customers { get; set; }
    }
}