using Projeto.DAL.DataSource;
using Projeto.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.DAL.Persistence
{
    public class EnderecoDal
    {
        public void Insert(Endereco endereco)
        {
            using (Conexao Con = new Conexao())
            {
                Con.Entry(endereco).State = EntityState.Added;
                Con.SaveChanges();
            }
        }

        public void Update(Endereco endereco)
        {
            using (Conexao Con = new Conexao())
            {
                Con.Entry(endereco).State = EntityState.Modified;
                Con.SaveChanges();
            }
        }

        public void Delete(Endereco endereco)
        {
            using (Conexao Con = new Conexao())
            {
                Con.Entry(endereco).State = EntityState.Deleted;
                Con.SaveChanges();
            }
        }

        public List<Endereco> FindAll()
        {
            using (Conexao con = new Conexao())
            {
                return con.Set<Endereco>().ToList();
            }
        }

        public Endereco findById(int id)
        {
            using (Conexao con = new Conexao())
            {
                return con.Set<Endereco>().Find(id);
            }
        }
    }
}
