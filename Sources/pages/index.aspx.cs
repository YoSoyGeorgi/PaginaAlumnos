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
    public partial class index : System.Web.UI.Page
    {
        readonly SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
        public static int Id;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void registrar_fact(object sender, EventArgs e)
        {
            int tamanioimagen = int.Parse(ticket.FileContent.Length.ToString());
            con.Open();
            byte[] imagen = ticket.FileBytes;
            using (con)
            {
                using (SqlCommand cmd = new SqlCommand("registrar_factura", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@rfc", SqlDbType.VarChar).Value = tbRFC.Text;
                    cmd.Parameters.Add("@direccion", SqlDbType.VarChar).Value = tbDir.Text;
                    cmd.Parameters.Add("@cp", SqlDbType.VarChar).Value = tbcp.Text;
                    cmd.Parameters.Add("@forma_pago", SqlDbType.VarChar).Value = FormaPago.Text;
                    cmd.Parameters.Add("@imagen", SqlDbType.Image).Value = imagen;
                    cmd.Parameters.Add("@razon", SqlDbType.VarChar).Value = motivo.Text;
                    cmd.ExecuteNonQuery();
                    con.Close();

                }
            }
        }
    }
}