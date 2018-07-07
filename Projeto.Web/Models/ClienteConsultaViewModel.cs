using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projeto.Web.Models
{
    public class ClienteConsultaViewModel
    {
        [Display(Name = "Codigo do Cliente: ")]
        public int IdCliente { get; set; }

        [Display(Name = "Nome do Cliente: ")]
        public string Nome { get; set; }

        [Display(Name = "E-mail do Cliente: ")]
        public string Email { get; set; }

        
        [Display(Name = "Telefone: ")]
        public string Telefone { get; set; }

        [Display(Name = "Data de Cadastro: ")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataCadastro { get; set; }

        [Display(Name = "Logradouro: ")]
        public string Logradouro { get; set; }

    }
}