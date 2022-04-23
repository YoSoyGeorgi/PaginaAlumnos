using System;
using System.Collections.Generic;
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

        protected void Registrarse(object sender, EventArgs e)
        {
            Response.Redirect("/Sources/pages/Registro.aspx");
        }
    }
}