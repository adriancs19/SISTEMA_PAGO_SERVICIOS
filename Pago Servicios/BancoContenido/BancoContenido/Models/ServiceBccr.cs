using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace BancoContenido.Models
{
    public class ServiceBccr
    {
        public string TipoCambio(string fecha)
        {
            cr.fi.bccr.gee.wsindicadoreseconomicos cliente = new cr.fi.bccr.gee.wsindicadoreseconomicos();

            DataSet tipocambio = cliente.ObtenerIndicadoresEconomicos("317", fecha, fecha, "NovaBank", "N", "aj1999cs@gmail.com", "LO0CG9A1LI");
            string valorTipoCambio = tipocambio.Tables[0].Rows[0].ItemArray[2].ToString();

            return valorTipoCambio;
        }
    }
}