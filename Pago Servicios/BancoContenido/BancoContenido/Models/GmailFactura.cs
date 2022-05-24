using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace BancoContenido.Models
{
    public class GmailFactura
    {
        public string EnviarCorreo(string CorreoDestino) {
            try
            {
                string emailorigen = "adrian19calderon@gmail.com";
                string contra = "AJCS1999";

                string asunto = "Token de Acceso";
                string mjs = "Estimado(a) Cliente." +
                    "Por este medio se le ajunta el token para su Ingreso al Sistema." +
                    "<h1 style='text - align:center'>TOKEN:</h1>" +
                    "<H3> Se le recuerda que su usuario y contraseña son de uso personal. No debe compartirlos con otras personas." +

                        "<br><br>Atentamente," +
                        "<br>Nova Bank." +

                        "<br><br>Este correo es de interés único del destinatario. Si usted lo recibió por error, elimínelo, por favor." +
                    "</ H3 > ";

                MailMessage oMailMessage = new MailMessage(emailorigen, CorreoDestino, asunto, mjs);

                oMailMessage.IsBodyHtml = true;

                SmtpClient oSmtpClient = new SmtpClient("smtp.gmail.com");
                oSmtpClient.EnableSsl = true;
                oSmtpClient.UseDefaultCredentials = false;
                oSmtpClient.Port = 587;
                oSmtpClient.Host = "smtp.gmail.com";
                oSmtpClient.Credentials = new System.Net.NetworkCredential(emailorigen, contra);

                oSmtpClient.Send(oMailMessage);

                oSmtpClient.Dispose();

                return "Correo Enviado";
            }
            catch (Exception)
            {

                return "Error al Enviar el Correo";

            }
            

        }

        
    }
}