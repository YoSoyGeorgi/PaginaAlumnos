using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PaginaAlumnos.Sources.Pages
{
    public partial class admin : System.Web.UI.MasterPage
    {

        readonly SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin_conectado"] != null)
            {
                int Id = int.Parse(Session["admin_conectado"].ToString());
                using (con)
                {
                    using (SqlCommand cmd = new SqlCommand("Perfil_admin", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
                        con.Open();
                        SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                        dr.Read();
                        this.lbadmin.Text = "Hola " + dr["Nombre"].ToString();
                    }
                }
            }
            else
            {
                Response.Redirect("LoginAdmin.aspx");
            }

        }

        protected void cerrar_admin(object sender, EventArgs e)
        {
            Session.Remove("admin_conectado");
            Response.Redirect("LoginAdmin.aspx");
        }
    }
}