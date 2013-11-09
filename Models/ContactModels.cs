using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;
//barnhen begin #1
namespace MVC4Crud2.Models
{
    [Table("Contact")]
    public class ContactModels
    {
        [Required]
        public Int32 ID { get; set; }
        [Required]
        public String FirstName { get; set; }
        public String MiddleName { get; set; }
        [Required]
        public String LastName { get; set; }
        public String Address { get; set; }
        public String City { get; set; }
        public String State { get; set; }
        public String Zip { get; set; }
        public String Country { get; set; }

    }
    public class ContactContext : DbContext
    {
        public DbSet<ContactModels> Contacts { get; set; }
    }

}