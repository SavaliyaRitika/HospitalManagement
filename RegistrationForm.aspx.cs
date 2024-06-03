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
        con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename="+apppath+@"APP_Data\Database.mdf;Integrated Security=True;
        User Instance=True");
        con.Open();
        string qry = "select max(UserID) from ClientRegistration";
        cmd = new SqlCommand(qry, con);
        SqlDataReader dr = cmd.ExecuteReader();
        dr.Read();
        int cid = Convert.ToInt32(dr[0]);
        cid++;
        txtUserID.Text = Convert.ToString(cid);
        dr.Close();
        con.Close();

    }
    
    protected void btnCancel_Click1(object sender, EventArgs e)
    {
        txtUserID.Text = "";
        txtUserName.Text = "";
        txtBirthDate.Text = "";
        txtEmail.Text = "";
        txtMobileNo.Text = "";
        txtUserID.Focus();
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
       
        cmd = new SqlCommand("Select * from  ClientRegistration  Where  UserID='"+txtUserID.Text+"'",con);
        SqlDataReader dr;
        con.Open();
        dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            Response.Write("<script LANGUAGE='Javascript' >alert('Sorry...,Duplicate Data.....')</script>");
            txtUserID.Text = "";
            txtUserName.Text = "";
            txtBirthDate.Text = "";
            txtEmail.Text = "";
            txtMobileNo.Text = "";
            txtUserID.Focus();

        }

        else
        {

            if (txtUserName.Text == ""||
                txtUserID.Text == ""||
                txtBirthDate.Text == ""||
                txtEmail.Text == ""||
                txtMobileNo.Text == "")
            {
                Response.Write("<script LANGUAGE='Javascript' >alert('Empty field not allowed....')</script>");

            }
            else
            {

                cmd = new SqlCommand("insert into ClientRegistration values('" + txtUserID.Text + "','" + txtUserName.Text + "','" + txtBirthDate.Text + "', '" + txtEmail.Text + "','" + txtMobileNo.Text + "','" + txtPassword.Text + "')", con);

               // Response.Write("<script LANGUAGE='Javascript' >alert('Data Added')</script>");

                dr.Close();
                cmd.ExecuteNonQuery();
                txtUserName.Text = "";
                txtUserID.Text = "";
                txtBirthDate.Text = "";
                txtEmail.Text = "";
                txtMobileNo.Text = "";
                txtUserID.Focus();

            }
            con.Close();
        }
      
    }
    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomeMain.aspx");
    }
}