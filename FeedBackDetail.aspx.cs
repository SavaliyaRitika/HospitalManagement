using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    SqlConnection con;
    DataSet DS;
    SqlDataAdapter DA;
    SqlDataReader dr1;
    string apppath = System.AppDomain.CurrentDomain.BaseDirectory;
    protected void Page_Load(object sender, EventArgs e)
    {
        con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=" + apppath + @"APP_Data\Database.mdf;Integrated Security=True; User Instance=True");
        //con.Open();
        //Response.Write("<script LANGUAGE='Javascript' >alert('Database Connected')</script>");

        DA = new SqlDataAdapter("Select *from FeedBack ", con);
        DS = new DataSet();
        DA.Fill(DS, "FeedBack");
        dgvFeedBack.DataSource = DS;
        dgvFeedBack.DataBind();
    }
    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomeAdmin.aspx");
    }
}