using System;
using System.Data;
using System.Data.SqlClient;

namespace prototipoTP4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string RutaBD = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Viajes;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                SqlConnection cn = new SqlConnection(RutaBD);
                cn.Open();

                SqlDataAdapter adap = new SqlDataAdapter("select * from provincias", cn);
                DataSet ds = new DataSet();

                adap.Fill(ds, "TablaProvincias");

                ddlProvInicio.DataSource = ds.Tables["TablaProvincias"];

                ddlProvInicio.DataTextField = "NombreProvincia";
                ddlProvInicio.DataValueField = "IdProvincia";

                ddlProvInicio.DataBind();
                cn.Close();

                if (ddlProvInicio.SelectedValue.Equals("1"))
                {
                    cn.Open();
                    adap = new SqlDataAdapter("select * from localidades where IdProvincia = 1", cn);
                    ds = new DataSet();
                    adap.Fill(ds, "TablaLocalidades");
                    ddlLocInicio.DataSource = ds.Tables["TablaLocalidades"];

                    ddlLocInicio.DataTextField = "NombreLocalidad";
                    ddlLocInicio.DataValueField = "IdLocalidad";

                    ddlLocInicio.DataBind();
                    cn.Close();

                    cn.Open();
                    adap = new SqlDataAdapter("select * from Provincias where IdProvincia not like 1", cn);
                    ds = new DataSet();
                    adap.Fill(ds, "TablaProvincias");
                    ddlProvFinal.DataSource = ds.Tables["TablaProvincias"];

                    ddlProvFinal.DataTextField = "NombreProvincia";
                    ddlProvFinal.DataValueField = "IdProvincia";

                    ddlProvFinal.DataBind();
                    cn.Close();

                    cn.Open();
                    adap = new SqlDataAdapter("select * from localidades where IdProvincia = 2", cn);
                    ds = new DataSet();
                    adap.Fill(ds, "TablaLocalidades");
                    ddlLocFinal.DataSource = ds.Tables["TablaLocalidades"];

                    ddlLocFinal.DataTextField = "NombreLocalidad";
                    ddlLocFinal.DataValueField = "IdLocalidad";

                    ddlLocFinal.DataBind();
                    cn.Close();
                }
            }
        }

        protected void ddlProvInicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ProvSelec = ddlProvInicio.SelectedValue;

            SqlConnection cn = new SqlConnection(RutaBD);
            cn.Open();

            SqlDataAdapter adap = new SqlDataAdapter("select * from localidades where IdProvincia = " + ProvSelec, cn);
            DataSet ds = new DataSet();
            adap.Fill(ds, "TablaLocalidades");
            ddlLocInicio.DataSource = ds.Tables["TablaLocalidades"];

            ddlLocInicio.DataTextField = "NombreLocalidad";
            ddlLocInicio.DataValueField = "IdLocalidad";

            ddlLocInicio.DataBind();
            cn.Close();

            cn.Open();
            adap = new SqlDataAdapter("select * from Provincias where IdProvincia not like " + ProvSelec, cn);
            ds = new DataSet();
            adap.Fill(ds, "TablaProvincias");
            ddlProvFinal.DataSource = ds.Tables["TablaProvincias"];

            ddlProvFinal.DataTextField = "NombreProvincia";
            ddlProvFinal.DataValueField = "IdProvincia";

            ddlProvFinal.DataBind();
            cn.Close();

            string ProvSelecF = ddlProvFinal.SelectedValue;

            cn.Open();
            adap = new SqlDataAdapter("select * from localidades where IdProvincia = " + ProvSelecF, cn);
            ds = new DataSet();
            adap.Fill(ds, "TablaLocalidades");
            ddlLocFinal.DataSource = ds.Tables["TablaLocalidades"];

            ddlLocFinal.DataTextField = "NombreLocalidad";
            ddlLocFinal.DataValueField = "IdLocalidad";

            ddlLocFinal.DataBind();
            cn.Close();
        }

        protected void ddlProvFinal_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ProvSelec = ddlProvFinal.SelectedValue;

            SqlConnection cn = new SqlConnection(RutaBD);
            cn.Open();

            SqlDataAdapter adap = new SqlDataAdapter("select * from localidades where IdProvincia = " + ProvSelec, cn);
            DataSet ds = new DataSet();
            adap.Fill(ds, "TablaLocalidades");
            ddlLocFinal.DataSource = ds.Tables["TablaLocalidades"];

            ddlLocFinal.DataTextField = "NombreLocalidad";
            ddlLocFinal.DataValueField = "IdLocalidad";

            ddlLocFinal.DataBind();
            cn.Close();
        }
    }
}


