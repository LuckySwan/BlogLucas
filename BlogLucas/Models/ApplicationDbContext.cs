using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogLucas.Models
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext() : base ( "DefaultConnetion")
        { }
        public static ApplicationDbContext Create() => new ApplicationDbContext();
        public DbSet<Post> Posts { get; set; }
    }
}