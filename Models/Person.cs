using System;
using System.ComponentModel.DataAnnotations;

namespace P10MvcWithIdentity.Models
{
  public class Person
  {
    public int Id { get; set; }

    [Display(Name = "First  Name")]
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public int Age { get; set; }
  }
}
