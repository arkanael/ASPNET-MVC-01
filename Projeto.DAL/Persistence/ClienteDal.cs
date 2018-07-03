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
    public class ClienteDal
    {
        public void Insert(Cliente cliente)
        {
            using (Conexao Con = new Conexao())
            {
                Con.Entry(cliente).State = EntityState.Added;
                Con.SaveChanges();
            }
        }

        public void Update(Cliente cliente)
        {
            using (Conexao Con = new Conexao())
            {
                Con.Entry(cliente).State = EntityState.Modified;
                Con.SaveChanges();
            }
        }

        public void Delete(Cliente cliente)
        {
            using (Conexao Con = new Conexao())
            {
                Con.Entry(cliente).State = EntityState.Deleted;
                Con.SaveChanges();
            }
        }

        public List<Cliente> FindAll()
        {
            using (Conexao con = new Conexao())
            {
                return con.Clientes.ToList();
            }
        }

        public Cliente FindById(int id)
        {
            using (Conexao con = new Conexao())
            {
                return con.Clientes.Find(id);
            }
        }

        public List<Cliente> FindByName(string nome)
        {
            if (nome == null)
            {
                using (Conexao con = new Conexao())
                {
                    return con.Clientes.ToList();
                }
            }
            else
            {
                using (Conexao con = new Conexao())
                {
                    return con.Clientes.Where(cliente => cliente.Nome.Contains(nome)).ToList();
                }

            }
        }

        public int count()
        {
            using (Conexao con = new Conexao())
            {
                return con.Clientes.Count();
            }
        }
    }
}
