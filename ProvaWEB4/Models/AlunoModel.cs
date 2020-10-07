using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProvaWEB4.Models
{
    public class AlunoModel
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Nome: ")]
        [Required(ErrorMessage = "Informe o Nome: ")]
        public string Nome { get; set; }

        [Display(Name = "Endereço: ")]
        [Required(ErrorMessage = "Informe o Endereço: ")]
        public string Endereco { get; set; }

        [Display(Name = "Filiação: ")]
        [Required(ErrorMessage = "Informe a Filiação: ")]
        public string Filiacao { get; set; }

        [Display(Name = "Curso: ")]
        [Required(ErrorMessage = "Informe o Curso: ")]
        public string Curso { get; set; }

        [Display(Name = "Telefone:")]
        [Required(ErrorMessage = "Informe o Telefone")]
        public string Telefone { get; set; }

        [Display(Name = "E-mail:")]
        [EmailAddress(ErrorMessage = "Informe o E-mail")]
        public string Email { get; set; }
    }
}