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
    SqlCommand cmd1;
    DataSet DS;
    SqlDataAdapter DA;
    SqlDataReader dr1;
    string apppath = System.AppDomain.CurrentDomain.BaseDirectory;
    protected void Page_Load(object sender, EventArgs e)
    {
        con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=" + apppath + @"APP_Data\Database.mdf;Integrated Security=True; User Instance=True");
       con.Open();
       string qry = "select max(UserID) from UserMaster";
       cmd = new SqlCommand(qry, con);
       SqlDataReader dr = cmd.ExecuteReader();
       dr.Read();
       int cid = Convert.ToInt32(dr[0]);
       cid++;
       txtUserId.Text = Convert.ToString(cid);
       dr.Close();
       con.Close();

        //Response.Write("<script LANGUAGE='Javascript' >alert('Database Connected')</script>");
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        txtUserId.Text = "";
        txtUserName.Text = "";
        txtUserCDate.Text = "";
        txtUserId.Focus();
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {

       cmd = new SqlCommand("Select * from  UserMaster  Where  UserID='"+txtUserId.Text+"'",con);
        SqlDataReader dr;
        con.Open();
        dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            Response.Write("<script LANGUAGE='Javascript' >alert('Sorry....,Duplicate Data...')</script>");
            txtUserId.Text = "";
            txtUserName.Text = "";
            txtUserCDate.Text = "";
            txtUserId.Focus();
            con.Close();

        }

        else
        {
            if (txtUserId.Text == "" || txtUserName.Text == "" || txtPassword.Text == "" || txtUserCDate.Text == "" 
                || txtRePassword.Text == "" )
            {
                Response.Write("<script LANGUAGE='Javascript' >alert('Empty field not allowed....')</script>");

            }
            else
            {
                //con.Open();

                cmd = new SqlCommand("Insert into UserMaster Values('" + txtUserId.Text + "','" + txtUserName.Text + "','" + ddlUserType.SelectedItem + "','" + txtPassword.Text + "','" + txtUserCDate.Text + "')", con);
                dr.Close();
                cmd.ExecuteNonQuery();
                // Response.Write("<script LANGUAGE='Javascript' >alert('Database Connected')</script>");
                DA = new SqlDataAdapter("Select *from UserMaster ", con);
                DS = new DataSet();
                DA.Fill(DS, "UserMaster");
                dgvUserMaster.DataSource = DS;
                dgvUserMaster.DataBind();
                txtUserId.Text = "";
                txtUserName.Text = "";
                txtUserCDate.Text = "";
                txtUserId.Focus();
                con.Close();
            }
        }
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        con.Open();
        DA = new SqlDataAdapter("Select *from UserMaster Where UserName Like  '%" + txtSearch.Text + "%'", con);
        DS = new DataSet();
        DA.Fill(DS, "UserMaster");
        dgvUserMaster.DataSource = DS;
        dgvUserMaster.DataBind();
        con.Close();
        
    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        con.Open();
        cmd = new SqlCommand("delete from UserMaster where UserID='" + txtSearch.Text + "'", con);
        cmd.ExecuteNonQuery();
        DA = new SqlDataAdapter("Select *from UserMaster ", con);
        DS = new DataSet();
        DA.Fill(DS, "UserMaster");
        dgvUserMaster.DataSource = DS;
        dgvUserMaster.DataBind();
        txtSearch.Text = "";
        con.Close();
       // Response.Write("<script LANGUAGE='Javascript' >alert('Data Deleted')</script>");
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        con.Open();

        cmd = new SqlCommand("update UserMaster  set UserName='" 
            + txtUserName.Text + "', UserType='"+ddlUserType.SelectedItem+"', Password='" + txtPassword.Text + "',UserCreationDate='"+txtUserCDate.Text+"' where UserID='" + txtSearch.Text + "'", con);
        cmd.ExecuteNonQuery();
       // Response.Write("<script LANGUAGE='Javascript' >alert('Data Updated')</script>");
        DA = new SqlDataAdapter("Select *from UserMaster Where UserID='" + txtSearch.Text + "'", con);

        DS = new DataSet();
        DA.Fill(DS, "UserMaster");
        dgvUserMaster.DataSource = DS;
        dgvUserMaster.DataBind();
        txtSearch.Text = "";
          txtUserId.Text = "";
        txtUserName.Text = "";
        txtUserCDate.Text = "";
        txtUserId.Focus();
    

       con.Close();
    }
    protected void btnShow_Click(object sender, EventArgs e)
    {
        con.Open();
        cmd1 = new SqlCommand("Select *from UserMaster where UserID='" + txtSearch.Text + "'", con);

       
        dr1 = cmd1.ExecuteReader();   
        if (dr1.HasRows)
        {
            while (dr1.Read())
            {
            
                txtUserId.Text = dr1["UserID"].ToString();
                txtUserName.Text = dr1["UserName"].ToString();
                txtUserCDate.Text = dr1["UserCreationDate"].ToString();
            }

            con.Close();
        }
    }
    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomeAdmin.aspx");
    }
}