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
    public partial class Historial : System.Web.UI.Page
    {
        readonly SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
        public static int Id;
        protected void Page_Load(object sender, EventArgs e)
        {
            Id = int.Parse(Session["UsuarioIngresado"].ToString());
            if (Session["UsuarioIngresado"] == null)
            {
                Response.Redirect("/Sources/Pages/Login.aspx");
            }
            else
            {

                using (SqlCommand cmd = new SqlCommand("Historial_cliente", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Historial_Usuarios.DataSource = dt;
                    Historial_Usuarios.DataBind();
                    
                  

                }
            }

        }
    }
}
/*cmd.CommandType = CommandType.StoredProcedure;
cmd.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
con.Open();
SqlDataReader dr = cmd.ExecuteReader();
if (dr.Read())
{
    this.tbNombres.Text = dr["Nombres"].ToString();
    this.tbApellidos.Text = dr["Apellidos"].ToString();
    this.tbUsuario.Text = dr["Email"].ToString();
    dr.Close();
}
con.Close();*/ 

