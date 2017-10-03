using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using UpnoidV4.Models;
using UpnoidV4.ViewModels;

namespace UpnoidV4.Controllers
{
    public class RentalsController : Controller
    {
        private ApplicationDbContext _context;

        public RentalsController()
        {
            _context = new ApplicationDbContext();
        }
        public ViewResult Index()
        {
            if (User.IsInRole(RoleName.CanManageMovies))
                return View("Index");
       
                return View("Index");
        }
        public ActionResult New()
        {
            if (User.IsInRole(RoleName.CanManageMovies))
            return View("New");

            return View("AccessDenied");
        }
        public ActionResult Details(int id)
        {
            var rental = _context.Rentals.Include(r => r.Movie).Include(r => r.Customer).SingleOrDefault(r => r.Id == id);
            if (rental == null)
                return HttpNotFound();

            return View(rental);
        }
    }
}