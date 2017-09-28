using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Mvc;
using System.Web.Http;
using UpnoidV4.Models;
using AutoMapper;
using System.Linq;
using System.Data.Entity;
using UpnoidV4.Dtos;


namespace UpnoidV4.Controllers.Api
{
    public class RentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public RentalsController()
        {
            _context = new ApplicationDbContext();
        }

        // GET /api/rentals
        public IHttpActionResult GetRentals(string query = null)
        {
            var rentalQuery = _context.Rentals
                .Include(r => r.Customer)
                .Include(r => r.Movie);

            var rentalDto = rentalQuery
                .ToList()
                .Select(Mapper.Map<Rental, RentalDto>);

            return Ok(rentalDto);
        }

        //GET /api/rentals/1
        public IHttpActionResult GetResult(int id)
        {
            var rental = _context.Rentals
                .SingleOrDefault(r => r.Id == id);

            if (rental == null)
                return NotFound();
            return Ok(Mapper.Map<Rental, RentalDto>(rental));
        }


        // DELETE /api/movies/1

        // [Authorize(Roles = RoleName.CanManageMovies)]
        [System.Web.Http.HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var rental = _context.Rentals.SingleOrDefault(r => r.Id == id);

            if (rental == null)
                return NotFound();

            _context.Rentals.Remove(rental);
            _context.SaveChanges();

            return Ok();

        }
    }
}
