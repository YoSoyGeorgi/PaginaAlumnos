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
    public partial class LoginAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        readonly SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        protected void Admin_login(object sender, EventArgs e)
        {
            if(tbpsadmin.Text == "" || tbusuario.Text == "")
            {
                lblerr.Text = "Por favor revisa tus datos e intenta nuevamente";
            }
            else
            {
                using (con)
                {
                    using (SqlCommand cmd = new SqlCommand("validar_admin", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = tbusuario.Text;
                        cmd.Parameters.Add("@Contraseña", SqlDbType.VarChar).Value = tbpsadmin.Text;
                        con.Open();
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            Session["admin_conectado"] = dr["Id"].ToString();
                            Response.Redirect("indexadmin.aspx");
                        }
                        else
                        {
                            lblerr.Text = "Usuario o contraseña incorrectos";
                        }
                        con.Close();
                    }

                }
            }
        }
    }
}