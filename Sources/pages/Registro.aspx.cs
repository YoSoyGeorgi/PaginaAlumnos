using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text.RegularExpressions;

namespace PaginaAlumnos.Sources.pages
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Cancelar(object sender, EventArgs e)
        {
            Response.Redirect("/Sources/pages/Login.aspx");
        }

        readonly SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        protected void Registrar(object sender, EventArgs e)
        {
            string contraseñaver = tbcont.Text;
            Regex letras = new Regex(@"[a-zA-Z]");
            Regex numeros = new Regex(@"[0-9]");
            Regex esp = new Regex("[!\"#\\$%&'()+*,.-/;:?@\\[\\]{|}]");

            SqlCommand usuario = new SqlCommand("ConteoUser, con");
            usuario.CommandType = CommandType.StoredProcedure;
            usuario.Parameters.Add("@usuario", SqlDbType.VarChar).Value = tbnum.Text;
            int user = Convert.ToInt32(usuario.ExecuteScalar());
            
            if(tbNombre.Text==""||tbapp.Text==""||tbnum.Text==""||tbemail.Text==""||ListaCarreras.SelectedValue == "")
            {
                lblerror.Text = "Los campos no pueden quedarse vacios, por favor verifica tu registro";
            }
            else if (user>=1)
            {
                lblerror.Text = "El usuario " + tbnum.Text + " Ya existe";
            }
        }
    }
}