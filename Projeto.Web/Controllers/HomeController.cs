using Projeto.DAL.Persistence;
using System;
using System.Web.Mvc;

namespace Projeto.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
         
            return View();
        }
    }
}