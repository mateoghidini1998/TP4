using System;
using System.Data.SqlClient;

namespace protoTP4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = @"Data Source=DESKTOP-VOTSJN5\SQLEXPRESS;Initial Catalog=Viajes;Integrated Security=True";
                cn.Open();

                SqlCommand cmd = new SqlCommand("Select * from Provincias", cn);
                SqlDataReader dr = cmd.ExecuteReader();

                ddlProvInicio.DataSource = dr;
                ddlProvInicio.DataTextField = "NombreProvincia";
                ddlProvInicio.DataValueField = "IdProvincia";
                ddlProvInicio.DataBind();

                dr.Close();
            }
        }

        protected void ddlProvInicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            string consulta = "Select * from Localidades where IdProvincia = " + ddlProvInicio.SelectedValue;
            MessageBox.Show(consulta);
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=DESKTOP-VOTSJN5\SQLEXPRESS;Initial Catalog=Viajes;Integrated Security=True";
            cn.Open();

            SqlCommand cmd = new SqlCommand(consulta, cn);
            SqlDataReader dr = cmd.ExecuteReader();

            ddlLocInicio.DataSource = dr;
            ddlLocInicio.DataTextField = "NombreLocalidad";
            ddlLocInicio.DataValueField = "IdLocalidad";
            ddlLocInicio.DataBind();

            dr.Close();


        }
    }
}