using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TurAppen.Model
{
    public class Person // This class is only here now for viewing the ApplicationUser props 
    {
        public int Id { get; set; }
        [NotMapped]
        public ICollection<Walk> History { get; set; }
        [NotMapped]
        public ICollection<Walk> AppliedFor { get; set; }
        public int Admin { get; set; } //not using claims and roles system, instead using api key stored as environment variabel, that is required for changing admin info.
        public string Name { get; set; }
        public int Level { get; set; } // Level; 0 = new, 1 = medium, 2 = Advanced. Enum on client side.
        [NotMapped]
        public ICollection<Comment> ReceivedRatings { get; set; }
    }
}
