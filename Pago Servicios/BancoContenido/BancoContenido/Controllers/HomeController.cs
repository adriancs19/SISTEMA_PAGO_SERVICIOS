using BancoContenido.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BancoContenido.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return RedirectToAction("inicioMenu");
        }

        public ActionResult inicioMenu()
        {
            string fecha = DateTime.Now.Date.ToString("dd/MM/yyyy");
            ServiceBccr cambio = new ServiceBccr();
            string tipocambio = cambio.TipoCambio(fecha);
            ViewBag.validacion = fecha;
            ViewBag.validacio = tipocambio;
            return View();
  
        }
    }


}