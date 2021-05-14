using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Time_Sheet.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ClientEmail { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]

        public string TelephoneNumber { get; set; }

        [Required]
        public string BuisnessName { get; set; }
 

    }
}