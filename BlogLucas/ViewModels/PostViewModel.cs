using BlogLucas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogLucas.ViewModels
{
    public class PostViewModel
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
        public IEnumerable<Author> Author { get; set; }
        [Required]
        public int Author_Id { get; set; }
    }
}