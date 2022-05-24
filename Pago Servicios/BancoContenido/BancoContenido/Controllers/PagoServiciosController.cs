using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BancoContenido.Models;

namespace BancoContenido.Controllers
{
    public class PagoServiciosController : Controller
    {
        public static string empresa;
        public static string codigo;
        public static string monto;
        // GET: PagoServicios
        public ActionResult Index()
        {
            return View();
        }

        // PAGOS DE SERVICIOS DE ELECTRICIDAD
        public ActionResult PagoElectricidad()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PagoElectricidad(FormCollection collection)
        {
            string empre = "";
            empre = Request.Form["compa"].ToString();
            string codig = Request.Form["codigo"].ToString();

            if (empre == "Select Option...")
            {
                ViewBag.validacion = "You need to select a company";
                return View();
            }
            if (codig == "")
            {
                ViewBag.validacio = "You need to select a code";
                return View();
            }
            empresa = empre;
            codigo = codig;
            if (empre == "Municipality")
            {
                ServiceReference1.PagoElectricidadMuniClient client = new ServiceReference1.PagoElectricidadMuniClient();
                monto = client.montopago(codig);
                return RedirectToAction("FacturaElectricidad");
            } else if(empre == "JASEC")
            {
                return View();
            }
            else if (empre == "ICE")
            {
                return View();
            }


            return View();
        }

        public ActionResult FacturaElectricidad()
        {
            ViewBag.empr = empresa;
            ViewBag.cod = codigo;
            ViewBag.monto = monto;
            return View();

        }
        [HttpPost]
        public ActionResult FacturaElectricidad(FormCollection collection)
        {
            string empre = "";
            empre = Request.Form["compa"].ToString();
            if (empre == "Select Option...")
            {
                ViewBag.empr = empresa;
                ViewBag.cod = codigo;
                ViewBag.monto = monto;
                ViewBag.validacion = "you need to select a payment type";
                return View();
            }

            if (empresa == "Municipality")
            {
                ServiceReference1.PagoElectricidadMuniClient client = new ServiceReference1.PagoElectricidadMuniClient();
               
                ViewBag.validacio = client.pago(codigo);
                return View();
            }
            else if (empresa == "JASEC")
            {
                return View();
            }
            else if (empresa == "ICE")
            {
                return View();
            }
            return View();
        }




        //PAGOS DE SERVICIOS DE AGUA
        public ActionResult PagoAGUA()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PagoAGUA(FormCollection collection)
        {
            string empre = "";
            empre = Request.Form["compa"].ToString();
            string codig = Request.Form["codigo"].ToString();

            if (empre == "Select Option...")
            {
                ViewBag.validacion = "You need to select a company";
                return View();
            }
            if (codig == "")
            {
                ViewBag.validacio = "You need to select a code";
                return View();
            }
            empresa = empre;
            codigo = codig;
            if (empre == "Asada Copalchí")
            {
                ServiceAguaAsada.PagoAguaAsadaClient client = new ServiceAguaAsada.PagoAguaAsadaClient();
                monto = client.montopago(codig);
                return RedirectToAction("FacturaAgua");
            }
            else if (empre == "AyA")
            {
                ServiceAguaAyA.PagoAguaAyAClient client = new ServiceAguaAyA.PagoAguaAyAClient();
                monto = client.montopago(codig);
                return RedirectToAction("FacturaAgua");
            }
            else if (empre == "Municipality")
            {
                ServiceAguaMuni.PagoAguaMuniClient client = new ServiceAguaMuni.PagoAguaMuniClient();
                monto = client.montopago(codig);
                return RedirectToAction("FacturaAgua");
            }


            return View();
        }

        public ActionResult FacturaAgua()
        {
            ViewBag.empr = empresa;
            ViewBag.cod = codigo;
            ViewBag.monto = monto;
            return View();

        }
        [HttpPost]
        public ActionResult FacturaAgua(FormCollection collection)
        {
            string empre = "";
            empre = Request.Form["compa"].ToString();
            if (empre == "Select Option...")
            {
                ViewBag.empr = empresa;
                ViewBag.cod = codigo;
                ViewBag.monto = monto;
                ViewBag.validacion = "you need to select a payment type";
                return View();
            }

            if (empresa == "Asada Copalchí")
            {
                ServiceAguaAsada.PagoAguaAsadaClient client = new ServiceAguaAsada.PagoAguaAsadaClient();

                ViewBag.validacio = client.pago(codigo);
                return View();
            }
            else if (empresa == "AyA")
            {
                ServiceAguaAyA.PagoAguaAyAClient client = new ServiceAguaAyA.PagoAguaAyAClient();

                ViewBag.validacio = client.pago(codigo);
                return View();
            }
            else if (empresa == "Municipality")
            {
                ServiceAguaMuni.PagoAguaMuniClient client = new ServiceAguaMuni.PagoAguaMuniClient();

                ViewBag.validacio = client.pago(codigo);
                return View();
            }
            return View();
        }




        //PAGOS DE SERVICIOS DE TELEFONO

        public ActionResult PagoTelefono()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PagoTelefono(FormCollection collection)
        {
            string empre = "";
            empre = Request.Form["compa"].ToString();
            string codig = Request.Form["codigo"].ToString();

            if (empre == "Select Option...")
            {
                ViewBag.validacion = "You need to select a company";
                return View();
            }
            if (codig == "")
            {
                ViewBag.validacio = "You need to select a code";
                return View();
            }
            empresa = empre;
            codigo = codig;
            if (empre == "Kolbi")
            {
                ServiceTelefonoKolbi.PagoTelefonoKolbiClient client = new ServiceTelefonoKolbi.PagoTelefonoKolbiClient();
                monto = client.montopago(codig);
                return RedirectToAction("FacturaTelefono");
            }
            else if (empre == "Claro")
            {
                ServiceTelefonoClaro.PagoTelefonoClaroClient client = new ServiceTelefonoClaro.PagoTelefonoClaroClient();
                monto = client.montopago(codig);
                return RedirectToAction("FacturaTelefono");
            }
            else if (empre == "Movistar")
            {
                ServiceTelefonoMovistar.PagoTelefonoMovistarClient client = new ServiceTelefonoMovistar.PagoTelefonoMovistarClient();
                monto = client.montopago(codig);
                return RedirectToAction("FacturaTelefono");
            }

            return View();
        }

        public ActionResult FacturaTelefono()
        {
            ViewBag.empr = empresa;
            ViewBag.cod = codigo;
            ViewBag.monto = monto;
            return View();

        }
        [HttpPost]
        public ActionResult FacturaTelefono(FormCollection collection)
        {
            string empre = "";
            empre = Request.Form["compa"].ToString();
            if (empre == "Select Option...")
            {
                ViewBag.empr = empresa;
                ViewBag.cod = codigo;
                ViewBag.monto = monto;
                ViewBag.validacion = "you need to select a payment type";
                return View();
            }

            if (empresa == "Kolbi")
            {
                ServiceTelefonoKolbi.PagoTelefonoKolbiClient client = new ServiceTelefonoKolbi.PagoTelefonoKolbiClient();

                ViewBag.validacio = client.pago(codigo);
                return View();
            }
            else if (empresa == "Claro")
            {
                ServiceTelefonoClaro.PagoTelefonoClaroClient client = new ServiceTelefonoClaro.PagoTelefonoClaroClient();

                ViewBag.validacio = client.pago(codigo);
                return View();
            }
            else if (empresa == "Movistar")
            {
             
                ServiceTelefonoMovistar.PagoTelefonoMovistarClient client = new ServiceTelefonoMovistar.PagoTelefonoMovistarClient();
                string monto = client.pago(codigo);
                ViewBag.validacio =" "+ monto;
                GmailFactura email = new GmailFactura();
                email.EnviarCorreo(correo);
                return View();
            }
            return View();
        }

    }
}