using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogLucas.Models
{
    public class Author
    {
        public int Id { get; set; }
        [StringLength(50)]
        [Required]
         
        public string Name { get; set; }
    }
}