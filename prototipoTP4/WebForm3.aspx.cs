using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace prototipoTP4
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
              if(IsPostBack == false)
            {
                SqlConnection cn = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=Neptuno;Integrated Security=True");
                //   cn.ConnectionString = "Data Source=localhost\\sqlexpress;Initial Catalog=Neptuno;Integrated Security=True";
                cn.Open();

                SqlCommand cmd = new SqlCommand("Select * from productos", cn);
                //  cmd.CommandText = "Select * from productos";
                // cmd.Connection = cn;

                SqlDataReader dr = cmd.ExecuteReader();

                dpwtema.DataSource = dr;
                dpwtema.DataBind();

                dpwtema.DataTextField = "NombreProducto";
                dpwtema.DataValueField = "IdProdcuto";
                dpwtema.DataBind();
                cn.Close();

            }
        }

    }
}