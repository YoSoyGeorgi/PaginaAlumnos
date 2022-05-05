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
            con.Open();
            SqlCommand usuario = new SqlCommand("ConteoUser", con);
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
            else if (tbcont.Text!=tbrepc.Text)
            {
                lblerror.Text = "Las contraseñas no coinciden";
            }
            else if (!letras.IsMatch(contraseñaver))
            {
                lblerror.Text = "La contraseña debe incluir letras";
            }
            else if (!esp.IsMatch(contraseñaver))
            {
                lblerror.Text = "La contraseña debe incluir caracteres especiales";
            }
            else if (!numeros.IsMatch(contraseñaver))
            {
                lblerror.Text = "La contraseña debe incluir numeros";
            }
            else
            {
                string patron = "contrasenialumno";
                using (con)
                {
                    using (SqlCommand cmd=new SqlCommand("Registrar", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@Nombres", SqlDbType.VarChar).Value = tbNombre.Text;
                        cmd.Parameters.Add("@Apellidos", SqlDbType.VarChar).Value = tbapp.Text;
                        cmd.Parameters.Add("@Num_control", SqlDbType.Char).Value = tbnum.Text;
                        cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = tbemail.Text;
                        cmd.Parameters.Add("@Carrera", SqlDbType.VarChar).Value = ListaCarreras.Text;
                        cmd.Parameters.Add("@Contraseña", SqlDbType.VarChar).Value = tbcont.Text;
                        cmd.Parameters.Add("@Patron", SqlDbType.VarChar).Value = patron;
                        cmd.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = 0;
                        cmd.ExecuteNonQuery();
                        
                    }
                    con.Close();
                    Response.Redirect("/Sources/pages/Login.aspx");
                }
            }
        }
    }
}