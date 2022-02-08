using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace TurAppen.Model
{

    public class ApplicationUser : IdentityUser // Person.cs
    {
        /*[NotMapped]
        public ICollection<Walk> History { get; set; } */
        public string HistoryJSON { get; set; } // Because the subject does not require security, performance and scalability

        /*[NotMapped]
        public ICollection<Walk> AppliedFor { get; set; }*/

        public string AppliedForJSON { get; set; } // Because the subject does not require security, performance and scalability

        public int Admin { get; set; } //not using claims and roles system, instead using api key stored as environment variabel, that is required for changing admin info.
        public string Name { get; set; }
        public int Level { get; set; } // Level; 0 = new, 1 = medium, 2 = Advanced. Enum on client side.

        /*[NotMapped]
        public ICollection<Comment> ReceivedRatings { get; set; }*/

        public string ReceivedRatingsJSON { get; set; } // Because the subject does not require security, performance and scalability

    }

    public class TurDBContext: IdentityDbContext<ApplicationUser>
    {
        
        public TurDBContext(DbContextOptions<TurDBContext> options): base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }


        public DbSet<TurAppen.Model.Walk> Walks { get; set; }
        //public DbSet<TurAppen.Model.Comment> Comments { get; set; }
    }
}
