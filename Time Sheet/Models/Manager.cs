using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Time_Sheet.Models
{
    public class Manager
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Position { get; set; }

        [NotMapped]
        public string Name
        {
            get
            {
                return this.FirstName + this.LastName;
            }
        }

        public virtual Client Client { get; set; }
    }
}