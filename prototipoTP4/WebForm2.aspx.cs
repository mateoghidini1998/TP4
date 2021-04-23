using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prototipoTP4
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        string RutaBD = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Neptuno;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {  
           if (IsPostBack == false)
           {
                SqlConnection cn = new SqlConnection(RutaBD);
                cn.Open();

                SqlCommand cmd = new SqlCommand("Select * from Productos", cn);
                SqlDataReader dr = cmd.ExecuteReader();

                gvProductos.DataSource = dr;
                gvProductos.DataBind();
           }  
        }

        protected void btnFiltro_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(RutaBD);
            SqlCommand comando = new SqlCommand("Select * from Productos where IdProducto = @IdProducto", cn);
            comando.Parameters.AddWithValue("@IdProducto", txtIdProducto.Text);
            cn.Open();

            SqlDataReader reg = comando.ExecuteReader();

            if(reg.Read())
            {
                gvProductos.DataSource = reg;
                gvProductos.DataBind();
            }

            cn.Close();
        }
    }
}