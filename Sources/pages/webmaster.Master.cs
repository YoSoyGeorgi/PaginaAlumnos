using System;
using System.Collections.Generic;
using System.Configuration;
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
            if(Session["userloged"]!=null)
            {
                int userloged = int.Parse(Session["userloged"].ToString());
                using (con)
                {
                    using(SqlCommand cmd = new SqlCommand("Perfil", con))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = userloged;
                        con.Open();
                        SqlDataReader dr = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                        dr.Read();
                        this.lblUser.Text = dr["Apellidos"].ToString()+", " + dr["Nombres"].ToString();
                    }
                }
            }
            else
            {
                Response.Redirect("/Sources/pages/Login.aspx");
            }
        }

        protected void Perfil(object sender, EventArgs e)
        {
            Response.Redirect("/Sources/pages/perfil.aspx");
        }


        protected void CS(object sender, EventArgs e)
        {
            Session.Remove("userloged");
            Response.Redirect("/Source/pages/Login.aspx");
        }
    }
}