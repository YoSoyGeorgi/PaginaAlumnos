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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        readonly SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        protected void Registrarse(object sender, EventArgs e)
        {
            Response.Redirect("/Sources/pages/Registro.aspx");
        }

        protected void Iniciar_Click(object sender, EventArgs e)
        {
            if (tbnumcon.Text == "" || tbpass.Text == "")
            {
                lblError.Text = "Por favor ingresa tu número de control o contraseña";
            }
            else
            {
                string patron = "contrasenialumno";
                using (con)
                {
                    using (SqlCommand cmd = new SqlCommand("Validar", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@Num_Control", SqlDbType.VarChar).Value = tbnumcon.Text;
                        cmd.Parameters.Add("@Contraseña", SqlDbType.VarChar).Value = tbpass.Text;
                        cmd.Parameters.Add("@Patron", SqlDbType.VarChar).Value = patron;
                        con.Open();
                        SqlDataReader dr = cmd.ExecuteReader();
                        if(dr.Read())
                        {
                            Session["userloged"] = dr["id"].ToString();
                            Response.Redirect("/Source/pages/index.aspx");
                        }
                        else
                        {
                            lblError.Text = "Usuario o contraseña incorrectos";
                        }
                        con.Close();
                    }
                }
            }
        }
            
    }
}
