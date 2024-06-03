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
         string qry = "select max(SrNo) from WardMaster";
         cmd = new SqlCommand(qry, con);
         SqlDataReader dr = cmd.ExecuteReader();
         dr.Read();
         int cid = Convert.ToInt32(dr[0]);
         cid++;
         txtSrNo.Text = Convert.ToString(cid);
         dr.Close();
         con.Close();
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        txtName.Text = "";
        txtSrNo.Text = "";
        txtBedNo.Text = "";
        txtWardNo.Text = "";
        txtSearch.Text = "";
        ddlWardType.Focus();

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        
        cmd = new SqlCommand("Select * from  WardMaster  Where  SrNo='" + txtSrNo.Text + "'", con);
        SqlDataReader dr;
        con.Open();
        dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            Response.Write("<script LANGUAGE='Javascript' >alert('Sorry....,Duplicate Data')</script>");
            txtName.Text = "";
            txtSrNo.Text = "";
            txtBedNo.Text = "";
            txtWardNo.Text = "";
            txtSearch.Text = "";
            ddlWardType.Focus();

        }

        else
        {
            if ( txtBedNo.Text ==""||  txtName.Text == ""||
            txtWardNo.Text == "" || txtSrNo.Text=="")
            {
                Response.Write("<script LANGUAGE='Javascript' >alert('Empty field not allowed....')</script>");

            }
            else
            {

            cmd = new SqlCommand("Insert into WardMaster (SrNo,WardType,WardNo,BedNo,PatientName) Values('"+txtSrNo.Text+"','" + ddlWardType.SelectedValue + "','" + txtWardNo.Text
                + "','" + txtBedNo.Text + "','" + txtName.Text + "')", con);
            dr.Close();
            cmd.ExecuteNonQuery();

            //Response.Write("<script LANGUAGE='Javascript' >alert('Database Added')</script>");
            DA = new SqlDataAdapter("Select *from WardMaster ", con);
            DS = new DataSet();
            DA.Fill(DS, "WardMaster");
            dgvWardMaster.DataSource = DS;
            dgvWardMaster.DataBind();
            txtName.Text = "";
            txtSrNo.Text="";
            txtBedNo.Text = "";
            txtWardNo.Text = "";
            txtSearch.Text = "";
            ddlWardType.Focus();
        }
        }
    }
    protected void btnShow_Click(object sender, EventArgs e)
    {
        con.Open();
        cmd1 = new SqlCommand("Select *from PatientRegistration where Name='" +txtName.Text+ "'", con);
        dr1 = cmd1.ExecuteReader();
        if (dr1.HasRows)
        {
            while (dr1.Read())
            {
            
                txtBedNo.Text = dr1["BedNo"].ToString();
                txtWardNo.Text = dr1["WardNo"].ToString();

            }
            dr1.Close();
        }
        con.Close();

        
        con.Open();
        cmd1 = new SqlCommand("Select *from WardMaster where SrNo='" + txtSearch.Text + "'", con);


        dr1 = cmd1.ExecuteReader();
        if (dr1.HasRows)
        {
            while (dr1.Read())
            {

                txtName.Text = dr1["PatientName"].ToString();
                txtSrNo.Text = dr1["SrNo"].ToString();
                txtBedNo.Text = dr1["BedNo"].ToString();
                txtWardNo.Text = dr1["WardNo"].ToString();
                
            }
            dr1.Close();
        }
        con.Close();
    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        con.Open();
        cmd = new SqlCommand("delete from WardMaster where SrNo='" + txtSearch.Text + "'", con);
        cmd.ExecuteNonQuery();
        DA = new SqlDataAdapter("Select *from WardMaster ", con);
        DS = new DataSet();
        DA.Fill(DS, "WardMaster");
        dgvWardMaster.DataSource = DS;
        dgvWardMaster.DataBind();
        txtSearch.Text = "";
        con.Close();
    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        con.Open();

        cmd = new SqlCommand("update WardMaster  set WardType='" + ddlWardType.SelectedItem + "', WardNo='" +
            txtWardNo.Text + "',BedNo='" + txtBedNo.Text + "',PatientName='" + txtName.Text
            + "' where SrNo='" + txtSearch.Text + "'", con);
        cmd.ExecuteNonQuery();
        // Response.Write("<script LANGUAGE='Javascript' >alert('Data Updated')</script>");
         DA = new SqlDataAdapter("Select *from WardMaster  Where SrNo='" + txtSearch.Text + "'", con);
        DS = new DataSet();
        DA.Fill(DS, "WardMaster");
        dgvWardMaster.DataSource = DS;
        dgvWardMaster.DataBind();
        txtName.Text = "";
        txtSrNo.Text = "";
        txtBedNo.Text = "";
        txtWardNo.Text = "";
        txtSearch.Text = "";
        ddlWardType.Focus();

        con.Close();
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        con.Open();
        DA = new SqlDataAdapter("Select *from WardMaster  Where PatientName Like  '%" + txtSearch.Text + "%'", con);
        DS = new DataSet();
        DA.Fill(DS, "WardMaster ");
        dgvWardMaster.DataSource = DS;
        dgvWardMaster.DataBind();
        con.Close();
    }
    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomeAdmin.aspx");
    }
}