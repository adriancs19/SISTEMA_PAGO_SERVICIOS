using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceTelefonoMovistar
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class PagoTelefonoMovistar : IPagoTelefonoMovistar
    {

        public static string coneccion = "Server = ADRIANCS\\AJCSSERVER; database = TelefonoMovistar; Trusted_Connection = true";
        public string correo(string medidor)
        {
            string resultado = " ";
            try
            {
                SqlConnection cnn = new SqlConnection(coneccion);

                DataTable dataTable = new DataTable();
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter sqlDA; cnn.Open();
                cmd.CommandText = "select coreoDueño from medidor where  codigoMedidor = '" + medidor + "'";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cnn;
                sqlDA = new SqlDataAdapter(cmd);
                sqlDA.Fill(dataTable);
                cnn.Close();

                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    resultado = dataTable.Rows[i][0].ToString();
                }
            }
            catch (Exception)
            {
                return "error";
            }
            return resultado;
        }

        string IPagoTelefonoMovistar.montopago(string medidor)
        {

            SqlConnection con = new SqlConnection(coneccion);
            con.Open();
            DataTable dataTable = new DataTable();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "monto";

            com.Parameters.Add("@medidor", SqlDbType.NVarChar).Value = medidor;
            SqlDataAdapter sqlDA = new SqlDataAdapter(com);
            sqlDA.Fill(dataTable);
            com.ExecuteNonQuery();
            con.Close();

            if (dataTable.Rows.Count == 0)
            {
                return "There are no receivables";
            }
            return "Amount payable" + dataTable.Rows[0][0].ToString(); ;
        }

        public string pago(string medidor)
        {
            try
            {


                SqlConnection con = new SqlConnection(coneccion);
                con.Open();
                DataTable dataTable = new DataTable();
                SqlCommand com = new SqlCommand();
                com.Connection = con;
                com.CommandType = CommandType.StoredProcedure;
                com.CommandText = "cancelacion";
                com.Parameters.Add("@medidor", SqlDbType.NVarChar).Value = medidor;
                com.ExecuteNonQuery();
                con.Close();
                return "Successful payment";
            }
            catch (Exception)
            {
                return "error";
            }
        }
    }
}






