using Projeto.DAL.Configuration;
using Projeto.Entidades;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Projeto.DAL.DataSource
{
    public class Conexao : DbContext
    {
        public Conexao():base(ConfigurationManager.ConnectionStrings["DataBase"].ConnectionString)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
          

            modelBuilder.Configurations.Add(new ClienteConfiguration());

        }

        public DbSet<Cliente> Clientes { get; set; }

    }
}
