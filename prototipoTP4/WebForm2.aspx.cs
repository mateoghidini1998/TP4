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

                cn.Close();
            }  
        }

        protected void btnFiltro_Click(object sender, EventArgs e)
        {        
            if(txtIdProducto.Text.Trim() != "" && txtIdCategoria.Text.Trim() == "")
            {
                filtroProductos();
                return;
            }
            if (txtIdProducto.Text.Trim() == "" && txtIdCategoria.Text.Trim() != "")
            {
                
            }

        }

        protected void btnSacarFiltros_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(RutaBD);
            cn.Open();

            SqlCommand cmd = new SqlCommand("Select * from Productos", cn);
            SqlDataReader dr = cmd.ExecuteReader();

            gvProductos.DataSource = dr;
            gvProductos.DataBind();
        }

        private void filtroProductos()
        {
            int aux;

            try
            {
                aux = Convert.ToInt32(txtIdProducto.Text);
            }
            catch
            {
                return;
            }

            SqlConnection cn = new SqlConnection(RutaBD);
            cn.Open();
            SqlCommand cmd = new SqlCommand("select * from productos where IdProducto " + ddlIdProducto.SelectedValue + aux, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            gvProductos.DataSource = dr;
            gvProductos.DataBind();
            cn.Close();
        }
    }
}