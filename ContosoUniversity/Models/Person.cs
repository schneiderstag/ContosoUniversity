using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public abstract class Person
    {
        /* This tutorial demonstrates how to implement TPH (table-per-hierarchy) inheritance. 
        TPH is the default inheritance pattern in the Entity Framework, 
        so all you have to do is create a Person class, 
        change the Instructor and Student classes to derive from Person, 
        add the new class to the DbContext, and create a migration. */

        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        [Column("FirstName")]
        [Display(Name = "First Name")]
        public string FirstMidName { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstMidName;
            }
        }
    }
}