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
         string qry = "select max(DischargeNo) from DischargeMaster";
        cmd = new SqlCommand(qry, con);
        SqlDataReader dr = cmd.ExecuteReader();
        dr.Read();
        int cid = Convert.ToInt32(dr[0]);
        cid++;
        txtDisNO.Text = Convert.ToString(cid);
        dr.Close();
        con.Close();

        
    
    

    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        txtName.Text = "";
        txtDisNO.Text = "";
        txtDisDate.Text = "";
        txtCharge.Text = "";
        txtDisNO.Focus();
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        cmd = new SqlCommand("Select * from  DischargeMaster  Where  DischargeNo='" + txtDisNO.Text + "'", con);
        SqlDataReader dr;
        con.Open();
        dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            Response.Write("<script LANGUAGE='Javascript' >alert('Sorry....,Duplicate Data')</script>");
            txtName.Text = "";
            txtDisNO.Text = "";
            txtDisDate.Text = "";
            txtCharge.Text = "";
            txtDisNO.Focus();


        }

        else
        {
            if ( txtName.Text==""||  txtDisNO.Text == ""||
            txtDisDate.Text == ""||
            txtCharge.Text == "")
            {
                Response.Write("<script LANGUAGE='Javascript' >alert('Empty field not allowed....')</script>");

            }
            else
            {
                cmd = new SqlCommand("Insert into DischargeMaster Values('" + txtDisNO.Text + "','" + txtName.Text
                    + "','" + txtDisDate.Text + "','" + ddlPatientType.SelectedItem + "','" + txtCharge.Text + "')", con);
                dr.Close();
                cmd.ExecuteNonQuery();

                //Response.Write("<script LANGUAGE='Javascript' >alert('Database Added')</script>");
                DA = new SqlDataAdapter("Select *from DischargeMaster ", con);
                DS = new DataSet();
                DA.Fill(DS, "DischargeMaster");
                dgvDischargeMaster.DataSource = DS;
                dgvDischargeMaster.DataBind();
                txtName.Text = "";
                txtDisNO.Text = "";
                txtDisDate.Text = "";
                txtCharge.Text = "";
                txtDisNO.Focus();
            }
        }

    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        con.Open();
        cmd = new SqlCommand("delete from DischargeMaster where DischargeNo='" + txtSearch.Text + "'", con);
        cmd.ExecuteNonQuery();
        DA = new SqlDataAdapter("Select *from DischargeMaster ", con);
        DS = new DataSet();
        DA.Fill(DS, "DischargeMaster");
        dgvDischargeMaster.DataSource = DS;
        dgvDischargeMaster.DataBind();
        txtSearch.Text = "";
        con.Close();
    }
  
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        con.Open();

        cmd = new SqlCommand("update DischargeMaster  set PatientName='"+txtName.Text
            + "', DischargeDate='" + txtDisDate.Text + "',PatientType='" + ddlPatientType.SelectedItem +
            "',Charge='" + txtCharge.Text + "' where DischargeNo='" + txtSearch.Text + "'", con);
        cmd.ExecuteNonQuery();
        // Response.Write("<script LANGUAGE='Javascript' >alert('Data Updated')</script>");
        DA = new SqlDataAdapter("Select *from DischargeMaster  Where DischargeNo='" + txtSearch.Text + "'", con);
        DS = new DataSet();
        DA.Fill(DS, "DischargeMaster ");
        dgvDischargeMaster.DataSource = DS;
        dgvDischargeMaster.DataBind();
        txtDisNO.Text = "";
        txtName.Text = "";
        txtDisDate.Text = "";
        txtCharge.Text = "";
        txtDisNO.Focus();


        con.Close();
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {

        con.Open();
        DA = new SqlDataAdapter("Select *from DischargeMaster  Where PatientName Like  '%" + txtSearch.Text + "%'", con);
        DS = new DataSet();
        DA.Fill(DS, "DischargeMaster ");
        dgvDischargeMaster.DataSource = DS;
        dgvDischargeMaster.DataBind();
        con.Close();
    }
    protected void btnShow_Click(object sender, EventArgs e)
    {
        con.Open();
        cmd1 = new SqlCommand("Select *from DischargeMaster where DischargeNo='" + txtSearch.Text + "'", con);


        dr1 = cmd1.ExecuteReader();
        if (dr1.HasRows)
        {
            while (dr1.Read())
            {
                txtName.Text = dr1["PatientName"].ToString();
                txtDisNO.Text = dr1["DischargeNo"].ToString();
                txtDisDate.Text = dr1["DischargeDate"].ToString();
                txtCharge.Text = dr1["Charge"].ToString();


            }

            con.Close();
        }
    }
    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomeAdmin.aspx");
    }
}