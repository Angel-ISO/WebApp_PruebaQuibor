using System;
using System.Data;
using System.Data.SqlClient;

namespace web_umg_bd
{
    public class ConexDb
    {
        // reemplazar cadena de conexion con la valida en sus instalaciones:Data Source=107.161.180.122,1433;Initial Catalog=datamaster;User Id=qbpruebaDSR;Password=W7s4@jcEjdo2lwWEeO2Jf;

        private string cadena = "server = localhost\\SQLEXPRESS; database = datamaster; Trusted_Connection = true; TrustServerCertificate=True;";
        public SqlConnection conectar = new SqlConnection();

        public void AbrirConexion()
        {
            try
            {
                conectar.ConnectionString = cadena;
                conectar.Open();
                //System.Diagnostics.Debug.WriteLine("conexion exitosa");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void CerrarConexion()
        {
            try
            {
                if (conectar.State == ConnectionState.Open)
                {
                    conectar.Close();
                    //System.Diagnostics.Debug.WriteLine("conexion cerrada");

                }
            }
            catch (Exception ex)
            {
               Console.WriteLine(ex.Message);
            }
        }
    }
}
