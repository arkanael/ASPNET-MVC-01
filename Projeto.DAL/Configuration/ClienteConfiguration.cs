using Projeto.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.DAL.Configuration
{
    public class ClienteConfiguration : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfiguration()
        {
            ToTable("Cliente");

            HasKey(cliente => cliente.IdCliente);

            Property(cliente => cliente.IdCliente)
                .HasColumnName("IdCliente")
                .IsRequired();

            Property(cliente => cliente.Nome)
                .HasColumnName("Nome")
                .HasMaxLength(50)
                .HasColumnType("varchar")
                .IsRequired();

            Property(cliente => cliente.Email)
               .HasColumnName("Email")
               .HasMaxLength(60)
               .HasColumnType("varchar")
               .IsRequired();

            Property(cliente => cliente.DataCadastro)
               .HasColumnName("DataCadastro")
               .HasColumnType("date")
               .IsRequired();
        }
    }
}