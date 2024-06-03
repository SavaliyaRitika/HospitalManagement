using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Default2 : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand cmd;
    string apppath = System.AppDomain.CurrentDomain.BaseDirectory;
    protected void Page_Load(object sender, EventArgs e)
    {
        con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=" + apppath + @"APP_Data\Database.mdf;Integrated Security=True;
        User Instance=True");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        txtUserName.Text = "";
        txtPass.Text = "";
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
       
        cmd = new SqlCommand("select * from UserMaster where UserName='"+txtUserName.Text+"' and Password='"+txtPass.Text+"' and UserType='"+ddlist1.SelectedItem+"'",con);
        SqlDataReader Dr;
        con.Open();
        Dr = cmd.ExecuteReader();
        if (Dr.HasRows)
            Response.Redirect("HomeAdmin.aspx");
        else
            Response.Write("<script LANGUAGE='Javascript' >alert('UsreID or password not incorrect')</script>");
        Dr.Close();


        cmd = new SqlCommand("select * from ClientRegistration where UserName='" + txtUserName.Text + "' and Password='" + txtPass.Text + "'", con);
        SqlDataReader Dr1;
        // con.Open();
        Dr1 = cmd.ExecuteReader();
        if (Dr1.HasRows)
            Response.Redirect("HomeClient.aspx");
        else
            Response.Write("<script LANGUAGE='Javascript' >alert('UsreID or password not incorrect')</script>");
        Dr.Close();
        con.Close();
    }
  
    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomeMain.aspx");
    }
}