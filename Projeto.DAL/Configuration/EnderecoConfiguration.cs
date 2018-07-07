using Projeto.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.DAL.Configuration
{
    public class EnderecoConfiguration : EntityTypeConfiguration<Endereco>
    {
        public EnderecoConfiguration()
        {
            ToTable("Endereco");
            HasKey(endereco => endereco.IdEndereco);

            Property(endereco => endereco.IdEndereco)
                .IsRequired();

            Property(endereco => endereco.Logradouro)
                 .HasColumnName("Logradouro")
                 .HasMaxLength(50)
                 .HasColumnType("varchar")
                 .IsRequired();

            HasRequired(endereco => endereco.Cliente)
                .WithOptional(cliente => cliente.Endereco);
        }
    }
}
