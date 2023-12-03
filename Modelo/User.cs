using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using web_umg_bd;
using System.Data;
using System.Web.UI.WebControls;


namespace Modelo
{
    public class User
    {
        ConexDb conectar;

        private DataTable ObtenerDatosUsuarios()
        {
            DataTable tabla = new DataTable();
            conectar = new ConexDb();
            conectar.AbrirConexion();

            string strConsulta = "SELECT UserId,  Nombre, apellido, telefono, ciudad, mes, ventames FROM Users; ";
            SqlDataAdapter consulta = new SqlDataAdapter(strConsulta, conectar.conectar);
            consulta.Fill(tabla);

            conectar.CerrarConexion();
            return tabla;
        }


        private DataTable grid_usuarios()
        {
            DataTable tabla = new DataTable();
            conectar = new ConexDb();
            conectar.AbrirConexion();
            string consulta = "SELECT UserId,  Nombre, apellido, telefono, ciudad, mes, ventames FROM Users;";
            SqlDataAdapter query = new SqlDataAdapter(consulta, conectar.conectar);
            query.Fill(tabla);
            conectar.CerrarConexion();
            return tabla;
        }

        public void grid_usuarios(GridView grid)
        {
            grid.DataSource = grid_usuarios();
            grid.DataBind();
        }

        private Dictionary<string, int> MesesDiccionario()
        {
            Dictionary<string, int> meses = new Dictionary<string, int>
        {
            {"Enero", 1},
            {"Febrero", 2},
            {"Marzo", 3},
            {"Abril", 4},
            {"Mayo", 5},
            {"Junio", 6},
            {"Julio", 7},
            {"Agosto", 8},
            {"Septiembre", 9},
            {"Octubre", 10},
            {"Noviembre", 11},
            {"Diciembre", 12}
        };

            return meses;
        }

        private int ObtenerValorMes(string nombreMes)
        {
            if (MesesDiccionario().TryGetValue(nombreMes, out int valorMes))
            {
                return valorMes;
            }
            return 0;
        }


        public int AgregarUsuario(string Nombre, string apellido, string telefono, string ciudad, string mes, decimal ventames)
        {
            int valorMes = ObtenerValorMes(mes);

            int no_ingreso = 0;
            conectar = new ConexDb();
            conectar.AbrirConexion();

            string strConsulta = $"INSERT INTO Users(Nombre, apellido, telefono, ciudad, mes, ventames) VALUES('{Nombre}', '{apellido}', '{telefono}', '{ciudad}', {valorMes}, {ventames});";
            SqlCommand insertar = new SqlCommand(strConsulta, conectar.conectar);

            insertar.Connection = conectar.conectar;
            no_ingreso = insertar.ExecuteNonQuery();
            conectar.CerrarConexion();
            return no_ingreso;
        }


        public int ModificarUsuario(int UserId, string Nombre, string apellido, string telefono, string ciudad, string nombreMes, decimal ventames)
        {
            int mes = ObtenerValorMes(nombreMes);

            int no_ingreso = 0;
            conectar = new ConexDb();
            conectar.AbrirConexion();

            string strConsulta = $"UPDATE Users SET Nombre = '{Nombre}', apellido = '{apellido}', telefono = '{telefono}', ciudad = '{ciudad}', mes = {mes}, ventames = {ventames} WHERE UserId = {UserId};";
            SqlCommand modificar = new SqlCommand(strConsulta, conectar.conectar);

            modificar.Connection = conectar.conectar;
            no_ingreso = modificar.ExecuteNonQuery();
            conectar.CerrarConexion();
            return no_ingreso;
        }



        public int EliminarUsuario(int UserId)
        {
            int no_ingreso = 0;
            conectar = new ConexDb();
            conectar.AbrirConexion();

            string strConsulta = $"DELETE FROM Users WHERE UserId = {UserId};";
            SqlCommand eliminar = new SqlCommand(strConsulta, conectar.conectar);

            eliminar.Connection = conectar.conectar;
            no_ingreso = eliminar.ExecuteNonQuery();
            conectar.CerrarConexion();
            return no_ingreso;
        }






    }
}
