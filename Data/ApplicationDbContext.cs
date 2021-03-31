using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using P10MvcWithIdentity.Models;

namespace P10MvcWithIdentity.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
      public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
          : base(options)
      {
      }

      public DbSet<Person> Persons { get; set; }

      public DbSet<Vehicle> Vehicles { get; set; }

      // protected override void OnConfiguring(DbContextOptionsBuilder options)
      //   => options.UseSqlServer("Server=localhost,1433; Database=P10;User=sa; Password=SomeDeveloperPassword");
    }
}
