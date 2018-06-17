using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Usuairo;

namespace server.Controllers
{
    public class HomeController : Controller
    {
        //public ActionResult Index()
        //{
        //    ViewBag.Title = "Home Page";

        //    return View();
        //}

        public string Index()
        {
            string v = "[{ id: 1}]";
            return v;
        }

        public alguma cadastra(info) {
            User = new UsuarioModel(info.nome, info.email);
            User.cadastra();
        }

    }
}
