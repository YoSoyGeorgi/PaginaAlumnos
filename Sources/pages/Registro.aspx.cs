using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

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
        }
    }
}