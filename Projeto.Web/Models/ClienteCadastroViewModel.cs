using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Web.Models
{
    public class ClienteCadastroViewModel
    {
        [MaxLength(50, ErrorMessage = "Nome deve ter no maximo {1} caracteres.")]
        [MinLength(3, ErrorMessage = "Nome deve ter no minimo {1} caracteres.")]
        [Display(Name = "Nome Completo: ")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Nome { get; set; }

        [EmailAddress(ErrorMessage = "Informe um e-mail válido.")]
        [Display(Name = "E-mail: ")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Email { get; set; }

        
        [DataType(DataType.PhoneNumber)]
        [MaxLength(11, ErrorMessage = "Nome deve ter no maximo {1} caracteres.")]
        [MinLength(11, ErrorMessage = "Nome deve ter no minimo {1} caracteres.")]
        [Display(Name = "Telefone com DDD: ")]
        public string Telefone { get; set; }

    }
}