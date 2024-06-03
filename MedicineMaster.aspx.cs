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
        con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=" + apppath + @"APP_Data\Database.mdf;Integrated Security=True;
        User Instance=True");
         con.Open();
         string qry = "select max(SrNo) from MedicineMaster";
         cmd = new SqlCommand(qry, con);
         SqlDataReader dr = cmd.ExecuteReader();
         dr.Read();
         int cid = Convert.ToInt32(dr[0]);
         cid++;
         txtSrNO.Text = Convert.ToString(cid);
         dr.Close();
         con.Close();

    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        txtSrNO.Text = "";
        txtGenericName.Text = "";
        txtBrandName.Text = "";

        txtPrice.Text = "";
        txtUses.Text = "";
        txtSrNO.Focus();
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        cmd = new SqlCommand("Select * from  MedicineMaster  Where  SrNo='" + txtSrNO.Text + "'", con);
        SqlDataReader dr;
        con.Open();
        dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            Response.Write("<script LANGUAGE='Javascript' >alert('Sorry....,Duplicate SrNo...')</script>");
            txtSrNO.Text = "";
            txtGenericName.Text = "";
            txtBrandName.Text = "";

            txtPrice.Text = "";
            txtUses.Text = "";
            txtSrNO.Focus();



        }

        else
        {

            if (txtSrNO.Text == ""||
            txtGenericName.Text == ""||
            txtBrandName.Text == ""||

            txtPrice.Text == ""||
            txtUses.Text == ""  )
            {
                Response.Write("<script LANGUAGE='Javascript' >alert('Empty field not allowed....')</script>");

            }
            else
            {

            cmd = new SqlCommand("Insert into MedicineMaster Values('"+txtSrNO.Text+"','" + txtGenericName.Text + "','"
                + txtBrandName.Text + "','" + txtPrice.Text + "','" + txtUses.Text + "')", con);
            dr.Close();
            cmd.ExecuteNonQuery();

            // Response.Write("<script LANGUAGE='Javascript' >alert('Database Added')</script>");
            DA = new SqlDataAdapter("Select *from MedicineMaster ", con);
            DS = new DataSet();
            DA.Fill(DS, "MedicineMaster");
            dgvMedicineMaster.DataSource = DS;
            dgvMedicineMaster.DataBind();
            txtSrNO.Text = "";
            txtGenericName.Text = "";
            txtBrandName.Text = "";

            txtPrice.Text = "";
            txtUses.Text = "";
            txtSrNO.Focus();
            con.Close();
        }
        }
    }
   
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        con.Open();
        cmd = new SqlCommand("delete from MedicineMaster where SrNo='" + txtSearch.Text + "'", con);
        cmd.ExecuteNonQuery();
        DA = new SqlDataAdapter("Select *from MedicineMaster ", con);
        DS = new DataSet();
        DA.Fill(DS, "MedicineMaster");
        dgvMedicineMaster.DataSource = DS;
        dgvMedicineMaster.DataBind();
        txtSearch.Text = "";
        con.Close();
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        con.Open();
        DA = new SqlDataAdapter("Select *from MedicineMaster Where GenericName Like  '%" + txtSearch.Text + "%'", con);
        DS = new DataSet();
        DA.Fill(DS, "MedicineMaster");
        dgvMedicineMaster.DataSource = DS;
        dgvMedicineMaster.DataBind();
        con.Close();

    }
    protected void btnShow_Click(object sender, EventArgs e)
    {
        con.Open();
        cmd1 = new SqlCommand("Select *from MedicineMaster where SrNo='" + txtSearch.Text + "'", con);


        dr1 = cmd1.ExecuteReader();
        if (dr1.HasRows)
        {
            while (dr1.Read())
            {

                txtSrNO.Text = dr1["SrNo"].ToString();
                txtGenericName.Text = dr1["GenericName"].ToString();
                txtBrandName.Text = dr1["BrandName"].ToString();
                txtPrice.Text = dr1["Price"].ToString();
                txtUses.Text = dr1["Uses"].ToString();

            }

            con.Close();
        }
    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        con.Open();

        cmd = new SqlCommand("update MedicineMaster  set  GenericName='"
            + txtGenericName.Text + "', BrandName='" + txtBrandName.Text + "',Price='"
            + txtPrice.Text + "',Uses='" + txtUses.Text + "' where SrNo='" + txtSearch.Text + "'", con);
        cmd.ExecuteNonQuery();
       // Response.Write("<script LANGUAGE='Javascript' >alert('Data Updated')</script>");
        DA = new SqlDataAdapter("Select *from MedicineMaster Where SrNo='" + txtSearch.Text + "'", con);
        DS = new DataSet();
        DA.Fill(DS, "MedicineMaster");
        dgvMedicineMaster.DataSource = DS;
        dgvMedicineMaster.DataBind();
        txtSearch.Text = "";
        txtSrNO.Text = "";
        txtGenericName.Text = "";
        txtBrandName.Text = "";
        txtPrice.Text = "";
        txtUses.Text = "";
        txtSrNO.Focus();


        con.Close();
    }
    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomeAdmin.aspx");
    }
}