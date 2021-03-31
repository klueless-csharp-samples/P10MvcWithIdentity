using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using P10MvcWithIdentity.Models;
using P10MvcWithIdentity.Data;

namespace P10MvcWithIdentity.Controllers
{
    public class PersonController : Controller
    {
        private readonly ILogger<PersonController> _logger;
        private readonly ApplicationDbContext _context;

        public PersonController(ILogger<PersonController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;

            _context.Persons.Add(new Person { FirstName = "David", LastName = "Cruwys", Age = 20 });
            _context.Persons.Add(new Person { FirstName = "Bob", LastName = "Hope", Age = 22 });
            _context.Persons.Add(new Person { FirstName = "Alice", LastName = "Wonderland", Age = 20 });
            _context.SaveChanges();
        }

        public IActionResult Index()
        {
          var people = _context.Persons.ToList();

          return View(people);
        }

        public IActionResult Details(int id)
        {
          var person = _context.Persons.FirstOrDefault( p => p.Id == id);

          if (person == null)
          {
            return NotFound();
          }

          return View(person);
        }

    }
}
