using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogLucas.Models
{
    public class Cadastro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        [Required]// deixa ele como obrigatorio
        [StringLength(50)]// nao deixar passar de 500 caracteres
        public string Endereco { get; set; }
        public int Telefone { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }

    }
}