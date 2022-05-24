using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary1
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class PagoElectricidadMuni : IPagoElectricidadMuni
    {
        public static string coneccion = "Server = ADRIANCS\\AJCSSERVER; database = ElectricidadMunicipalidad; Trusted_Connection = true";
        
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

        string IPagoElectricidadMuni.montopago( string medidor)
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

            
            
             if(dataTable.Rows.Count == 0){
                return "There are no receivables";
            }
            return "Amount payable" +dataTable.Rows[0][0].ToString(); ;
        }
    }
}
