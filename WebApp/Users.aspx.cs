using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using web_umg_bd;

namespace WebApp
{
    public partial class WebForm1 : Page
    {
        User user;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                user = new User();
                user.grid_usuarios(grid_usuarios);
            }
        }

        protected void txtNombres_TextChanged(object sender, EventArgs e)
        {

        }



        protected void BtnGuardar_Click(object sender, EventArgs e)
        {

            User user = new User();

            string Nombre = txtNombres.Text;
            string apellido = txtApellidos.Text;
            string telefono = txtTelefono.Text;
            string ciudad = txtCiudad.Text;
            string mes = ddlMes.SelectedItem.Text;
            decimal ventames;

            if (decimal.TryParse(txtVentaMes.Text, out ventames) && ventames > 0)
            {
                if (user.AgregarUsuario(Nombre, apellido, telefono, ciudad, mes, ventames) > 0)
                {
                    lbl_mensaje.Text = "Usuario agregado exitosamente";
                    user.grid_usuarios(grid_usuarios);
                }
                else
                {
                    lbl_mensaje.Text = "Error al agregar usuario";
                }
            }
            else
            {
                lbl_mensaje.Text = "El valor de VentaMes es inválido o está vacío";
            }

        }

        protected void grid_usuarios_SelectedIndexChanged(object sender, EventArgs e)
        {

            string nombres = grid_usuarios.SelectedRow.Cells[1].Text;
            string apellidos = grid_usuarios.SelectedRow.Cells[2].Text;
            string telefono = grid_usuarios.SelectedRow.Cells[3].Text;
            string ciudad = grid_usuarios.SelectedRow.Cells[4].Text;
            string ventaMes = grid_usuarios.SelectedRow.Cells[5].Text;

            txtNombres.Text = nombres;
            txtApellidos.Text = apellidos;
            txtTelefono.Text = telefono;
            txtCiudad.Text = ciudad;
            txtVentaMes.Text = ventaMes;

            int numeroMes;
            if (int.TryParse(ventaMes, out numeroMes))
            {
                ddlMes.ClearSelection();
                ddlMes.Items.FindByValue(numeroMes.ToString()).Selected = true;
            }

            Btn_actualizar.Visible = true;

        }

        protected void grid_usuarios_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int userId = Convert.ToInt32(grid_usuarios.DataKeys[e.RowIndex].Value);

            User user = new User();
            if (user.EliminarUsuario(userId) > 0)
            {
                lbl_mensaje.Text = "Usuario eliminado exitosamente.";
                user.grid_usuarios(grid_usuarios);
            }
            else
            {
                lbl_mensaje.Text = "Error al eliminar al usuario.";
            }
        }

        protected void Btn_actualizar_Click(object sender, EventArgs e)
        {
            User user = new User();

            int userId = Convert.ToInt32(grid_usuarios.SelectedValue);
            string nombre = txtNombres.Text;
            string apellido = txtApellidos.Text;
            string telefono = txtTelefono.Text;
            string ciudad = txtCiudad.Text;
            string nombreMes = ddlMes.SelectedItem.Text;
            decimal ventaMes;

            if (decimal.TryParse(txtVentaMes.Text, out ventaMes) && ventaMes > 0)
            {
                if (user.ModificarUsuario(userId, nombre, apellido, telefono, ciudad, nombreMes, ventaMes) > 0)
                {
                    user.grid_usuarios(grid_usuarios);
                    lbl_mensaje.Text = "Usuario modificado exitosamente.";
                }
                else
                {
                    lbl_mensaje.Text = "Error al modificar al usuario.";
                }
            }
            else
            {
                lbl_mensaje.Text = "El valor de VentaMes es inválido o está vacío.";
            }
        }





    }
}