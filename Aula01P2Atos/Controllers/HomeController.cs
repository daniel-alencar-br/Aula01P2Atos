using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aula01P2Atos.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Imagem()
        {
            var Arq = Server.MapPath("/Arqs/Img01.jpg");
            return base.File(Arq, "image/jpeg");
        }

        public ActionResult Documento()
        {
            var Arq = Server.MapPath("/Arqs/Academia.pdf");
            return base.File(Arq, "application/pdf");
        }

        public ActionResult TransferenciaDados()
        {
            // Existem durante a comunicação
            // Stateless 
            ViewData["Codigo"] = "1";
            ViewBag.Nome = "Joao";
            
            // Statefull
            Session["Autenticado"] = "OK";  // por usuário
            
            return View();
        }

        public string OlaMundo()
        {
            return "Olá Mundo!!!!";
        }

        public string DadosXML()
        {
            return "<clientes>"+
                   "  <cliente>"+
                   "    <cod>1</cod>"+
                   "    <nome>Joao</nome>" +
                   "  </cliente>" +
                   "</clientes>";
        }


    }
}