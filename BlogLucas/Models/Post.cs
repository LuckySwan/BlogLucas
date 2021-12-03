using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogLucas.Models
{
    public class Post
    {
        //DataAnnotations
        public int Id { get; set; }
        [Required]// deixa ele como obrigatorio
        [StringLength(500)]// nao deixar passar de 500 caracteres
        public string Title { get; set; }
        [Required]
        [StringLength(4000)]// nao deixar passar de 4000 caracteres
        [AllowHtml]// permite usar o HTML
        public string Body { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public Author Author { get; set; }
        public int AuthorId { get; set; }
    }
}