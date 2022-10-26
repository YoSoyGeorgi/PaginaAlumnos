using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PaginaAlumnos.Sources.pages
{
    public partial class webmaster : System.Web.UI.MasterPage
    {
        
        readonly SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UsuarioIngresado"] != null)
            {
                int Id = int.Parse(Session["UsuarioIngresado"].ToString());
                using (con)
                {
                    using (SqlCommand cmd = new SqlCommand("Perfil", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
                        con.Open();
                        SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                        dr.Read();
                        this.lblUser.Text = "Hola " + dr["Nombres"].ToString() + ' ' + dr["Apellidos"].ToString();
                    }
                }
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void Inicio(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }

        protected void Historial(object sender, EventArgs e)
        {
            Response.Redirect("Historial.aspx");
        }
        protected void Perfil(object sender, EventArgs e)
        {
            Response.Redirect("perfil.aspx");
        }


        protected void CS(object sender, EventArgs e)
        {
            Session.Remove("UsuarioIngresado");
            Response.Redirect("Login.aspx");
        } 

    }
}