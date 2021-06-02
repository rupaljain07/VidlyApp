using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using Vidly.Models;
using System.Web;
using System.Web.Mvc;

namespace Vidly.Controllers
{

    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;
        //dbcontext to access the database
        public CustomersController()
        {
            //initialise dbcontext in constructor
            _context = new ApplicationDbContext();
        }

        //since dbcontext is disposable object, so we dispose by overriding the dispose method of base controller class
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Customers
        public ViewResult Index()
        {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();
            return View(customers);

        }

        public ActionResult Details(int id)
        {
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();
            return View(customer);
        }

        
    }
}