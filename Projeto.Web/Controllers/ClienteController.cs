using Projeto.DAL.Persistence;
using Projeto.Entidades;
using Projeto.Web.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Projeto.Web.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente/Cadastro
        [HttpGet]
        public ActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastro(ClienteCadastroViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Cliente cliente = new Cliente();
                    cliente.Endereco = new Endereco();

                    cliente.Nome = model.Nome;
                    cliente.Email = model.Email;
                    cliente.Telefone = model.Telefone;
                    cliente.DataCadastro = DateTime.Now;
                    cliente.Endereco.Logradouro = model.Logradouro; 

                    ClienteDal d = new ClienteDal();
                    d.Insert(cliente);

                    ViewBag.Mensagem = "Cliente cadastrado com sucesso.";
                    ModelState.Clear();
                }
                catch (Exception erro)
                {
                    ViewBag.Mensagem = erro.Message;
                }
            }

            return View();
        }

        // GET: Cliente/ConsultaClientes
        [HttpGet]
        public ActionResult Consulta()
        {
            return View();
        }

        // POST: Cliente/Consulta
        [HttpPost]
        public ActionResult Consulta(ClienteConsultaViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    ClienteDal d = new ClienteDal();
                    ViewBag.Dados = d.FindByName(model.Nome);
                }
                catch (Exception erro)
                {
                    ViewBag.Mensagem = erro.Message;
                }
            }

            return View();
        }

        // GET: Cliente/Detalhes/id
        [HttpGet]
        public ActionResult Detalhes(int id)
        {
            ClienteConsultaViewModel model = new ClienteConsultaViewModel();
            try
            {
                ClienteDal d = new ClienteDal();

                Cliente cliente = new Cliente();

                cliente.Endereco = new Endereco();

                cliente = d.FindById(id);

                model.IdCliente = cliente.IdCliente;
                model.Nome = cliente.Nome;
                model.Email = cliente.Email;
                model.Telefone = cliente.Telefone;
                model.DataCadastro = cliente.DataCadastro;
                model.Logradouro = cliente.Endereco.Logradouro;
            }
            catch (Exception erro)
            {
                ViewBag.Mensagem = erro.Message;
            }

            return View(model);
        }

        // GET: Cliente/Edicao/int
        [HttpGet]
        public ActionResult Edicao(int id)
        {
            ClienteEdicaoViewModel model = new ClienteEdicaoViewModel();
            try
            {
                ClienteDal d = new ClienteDal();
                EnderecoDal ed = new EnderecoDal();

                Cliente cliente = new Cliente();
                cliente.Endereco = new Endereco();

                cliente = d.FindById(id);
                cliente.Endereco = ed.findById(id);

                model.IdCliente = cliente.IdCliente;
                model.Nome = cliente.Nome;
                model.Email = cliente.Email;
                model.Telefone = cliente.Telefone;
                model.DataCadastro = cliente.DataCadastro;


                model.IdEndereco = cliente.Endereco.IdEndereco;
                model.Logradouro = cliente.Endereco.Logradouro;
            }
            catch (Exception erro)
            {
                ViewBag.Mensagem = erro.Message;
            }

            return View(model);
        }


        [HttpPost]
        public ActionResult Edicao(ClienteEdicaoViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    ClienteDal d = new ClienteDal();
                    EnderecoDal ed = new EnderecoDal();

                    Cliente cliente = new Cliente();
                    cliente.Endereco = new Endereco();

                    cliente.IdCliente = model.IdCliente;
                    cliente.Nome = model.Nome;
                    cliente.Email = model.Email;
                    cliente.Telefone = model.Telefone;
                    cliente.DataCadastro = model.DataCadastro;

                    cliente.Endereco.IdEndereco = model.IdEndereco;
                    cliente.Endereco.Logradouro = model.Logradouro;

                    d.Update(cliente);
                    ed.Update(cliente.Endereco);

                    ViewBag.Mensagem = "Cliente atualizado com sucesso.";
                    ModelState.Clear();
                    return RedirectToAction("Consulta");

                }
                catch (Exception erro)
                {
                    ViewBag.Mensagem = erro.Message;
                }
            }

            return View(model);

        }

        // GET: Cliente/Exclusao/id
        [HttpGet]
        public ActionResult Exclusao(int id)
        {
            try
            {
                ClienteDal d = new ClienteDal();

                Cliente cliente = d.FindById(id);

                d.Delete(cliente);

                ViewBag.Mensagem = $"Cliente {cliente.Nome} Excluido com sucesso";

            }
            catch (Exception erro)
            {
                ViewBag.Mensagem = erro.Message;
            }

            return RedirectToAction("Consulta");

        }
    }
}