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
        public DbSet<Author> Authors { get; set; }
        public DbSet<Cadastro> Cadastro { get; set; }
        public object Cadastros { get; internal set; }
    }
}