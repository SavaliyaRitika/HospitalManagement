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
    SqlCommand cmd;
    string apppath = System.AppDomain.CurrentDomain.BaseDirectory;
    protected void Page_Load(object sender, EventArgs e)
    {
        con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=" + apppath + @"APP_Data\Database.mdf;Integrated Security=True;
        User Instance=True");
        con.Open();
        string qry = "select max(RegistrationNo) from FeedBack";
        cmd = new SqlCommand(qry, con);
        SqlDataReader dr = cmd.ExecuteReader();
        dr.Read();
        int cid = Convert.ToInt32(dr[0]);
        cid++;
        
       txtRagistration.Text = Convert.ToString(cid);
        dr.Close();
        con.Close();
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        txtRagistration.Text = "";
        txtName.Text = "";
        txtContactNo.Text="";
        txtEmailID.Text = "";
        txtMessage.Text = "";
        txtRagistration.Focus();
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        cmd = new SqlCommand("Select * from  Feedback  Where  RegistrationNo='" + txtRagistration.Text + "'", con);
        SqlDataReader dr;
        con.Open();
        dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            Response.Write("<script LANGUAGE='Javascript' >alert('Sorry....,Duplicate Data...')</script>");
            txtRagistration.Text = "";
            txtName.Text = "";
            txtContactNo.Text = "";
            txtEmailID.Text = "";
            txtMessage.Text = "";
            txtRagistration.Focus();


        }
        else
        {
            if (txtRagistration.Text == "" || txtName.Text == "" || txtContactNo.Text == "" ||
                txtEmailID.Text == "" || txtMessage.Text == "")
            {
                Response.Write("<script LANGUAGE='Javascript' >alert('Empty field not allowed....')</script>");

            }
            else
            {
                dr.Close();




                cmd = new SqlCommand("insert into Feedback values('" + txtRagistration.Text + "','" + txtName.Text + "','"
                    + txtContactNo.Text + "', '" + txtEmailID.Text + "','" + txtMessage.Text + "')", con);
                // Response.Write("<script LANGUAGE='Javascript' >alert('Data Added')</script>");
                cmd.ExecuteNonQuery();
                txtRagistration.Text = "";
                txtName.Text = "";
                txtContactNo.Text = "";
                txtEmailID.Text = "";
                txtMessage.Text = "";
                txtRagistration.Focus();
                con.Close();
            }
        }
    }
    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomeClient.aspx");
    }
}