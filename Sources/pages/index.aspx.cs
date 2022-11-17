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
                using (SqlCommand cmd = new SqlCommand("Registrar_factura", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@RFC", SqlDbType.VarChar).Value = tbRFC.Text;
                    cmd.Parameters.Add("@Razon_social", SqlDbType.VarChar).Value = lbrs.Text;
                    cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = tbnrs.Text;
                    cmd.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = tbdir.Text;
                    cmd.Parameters.Add("@CP", SqlDbType.VarChar).Value = tbcp.Text;
                    cmd.Parameters.Add("@Ciudad", SqlDbType.VarChar).Value = tbciudad.Text;
                    cmd.Parameters.Add("@Estado", SqlDbType.VarChar).Value = tbestado.Text;
                    cmd.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = tbcel.Text;
                    cmd.Parameters.Add("@Correo", SqlDbType.VarChar).Value = tbcorreo.Text;
                    cmd.Parameters.Add("@Concepto", SqlDbType.VarChar).Value = lbconcepto.Text;
                    cmd.Parameters.Add("@Imgen", SqlDbType.Image).Value = imagen;
                    cmd.Parameters.Add("@zip", SqlDbType.VarBinary).Value = null;
                    cmd.Parameters.Add("@Estatus", SqlDbType.VarChar).Value = "Pendiente";

                    Id = int.Parse(Session["UsuarioIngresado"].ToString());
                    using (SqlCommand cmd1 = new SqlCommand("Perfil", con))
                    {
                        cmd1.CommandType = CommandType.StoredProcedure;
                        cmd1.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
                        SqlDataReader dr = cmd1.ExecuteReader();
                        if (dr.Read())
                        {
                            cmd.Parameters.Add("@Id_cliente", SqlDbType.Int).Value = dr["Id"].ToString();
                            dr.Close();
                        }
                        
                    }
                    
                    cmd.ExecuteNonQuery();
                    con.Close();

                }
            }
        }
    }
}