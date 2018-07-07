using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entidades
{
    public class Endereco
    {
        public int IdEndereco { get; set; }
        public string Logradouro { get; set; }

        public Cliente Cliente { get; set; } 
    }
}
