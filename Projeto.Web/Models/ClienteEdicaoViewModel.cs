﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projeto.Web.Models
{
    public class ClienteEdicaoViewModel
    {
        [Display(Name = "Código: ")]
        public int IdCliente { get; set; }

        [MaxLength(50, ErrorMessage = "Nome deve ter no maximo {1} caracteres.")]
        [MinLength(3, ErrorMessage = "Nome deve ter no minimo {1} caracteres.")]
        [Display(Name = "Nome: ")]
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

        [Display(Name = "Data de Cadastro: ")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataCadastro { get; set; }

        public int IdEndereco { get; set; }

        [MaxLength(50, ErrorMessage = "Endereco deve ter no maximo {1} caracteres.")]
        [MinLength(3, ErrorMessage = "Endereco deve ter no minimo {1} caracteres.")]
        [Display(Name = "Logradouro: ")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Logradouro { get; set; }

    }
}