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
    string rbtn;
    protected void Page_Load(object sender, EventArgs e)
    {
        con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=" + apppath + @"APP_Data\Database.mdf;Integrated Security=True; User Instance=True");
          con.Open();
        string qry = "select max(DrID) from DoctorMaster";
        cmd = new SqlCommand(qry, con);
        SqlDataReader dr = cmd.ExecuteReader();
        dr.Read();
        int cid = Convert.ToInt32(dr[0]);
        cid++;
        txtDrID.Text = Convert.ToString(cid);
        dr.Close();
        con.Close();
        // Response.Write("<script LANGUAGE='Javascript' >alert('Database Connected')</script>");
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        txtAddress.Text = "";
        txtAge.Text = "";
        txtBirthDate.Text = "";
        txtDrID.Text = "";
        txtDrName.Text = "";
        txtEmail.Text = "";
        txtJoinDate.Text = "";
        txtMobileNo.Text = "";
        txtDrID.Focus();
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {


        cmd = new SqlCommand("Select * from  DoctorMaster  Where  DrID='" + txtDrID.Text + "'", con);
        SqlDataReader dr;
        con.Open();
        dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            Response.Write("<script LANGUAGE='Javascript' >alert('Sorry....,Duplicate Data...')</script>");
            txtAddress.Text = "";
            txtAge.Text = "";
            txtBirthDate.Text = "";
            txtDrID.Text = "";
            txtDrName.Text = "";
            txtEmail.Text = "";
            txtJoinDate.Text = "";
            txtMobileNo.Text = "";

            txtDrID.Focus();
            con.Close();

        }

        else
        {
            if ( txtAddress.Text == "" ||
            txtAge.Text == "" ||
            txtBirthDate.Text == "" ||
            txtDrID.Text == "" ||
            txtDrName.Text == "" ||
            txtEmail.Text =="" ||
            txtJoinDate.Text == "" ||
            txtMobileNo.Text == "")
            {
                Response.Write("<script LANGUAGE='Javascript' >alert('Empty field not allowed....')</script>");

            }
            else
            {
                //con.Open();

                // string rbtn;

                if (rbMale.Checked == true)
                {
                    rbtn = "M";

                }
                else
                {
                    rbtn = "F";

                }

                cmd = new SqlCommand("Insert into DoctorMaster Values('" + txtDrID.Text + "','" + txtDrName.Text + "','" + rbtn + "',  '" + txtAge.Text + "','"
                    + ddlSpeci.SelectedItem + "','" + txtJoinDate.Text + "','" + txtBirthDate.Text + "','" + txtAddress.Text + "','" + txtMobileNo.Text + "','" + txtEmail.Text + "')", con);
                dr.Close();
                cmd.ExecuteNonQuery();
                //  Response.Write("<script LANGUAGE='Javascript' >alert('Database Added')</script>");
                DA = new SqlDataAdapter("Select *from DoctorMaster", con);
                DS = new DataSet();
                DA.Fill(DS, "DoctorMaster");
                dgvDoctorMaster.DataSource = DS;
                dgvDoctorMaster.DataBind();
                txtAddress.Text = "";
                txtAge.Text = "";
                txtBirthDate.Text = "";
                txtDrID.Text = "";
                txtDrName.Text = "";
                txtEmail.Text = "";
                txtJoinDate.Text = "";
                txtMobileNo.Text = "";

                txtDrID.Focus();
                con.Close();
            }
        }
    }
   
  
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        con.Open();
        DA = new SqlDataAdapter("Select *from DoctorMaster Where Name Like  '%" + txtSearch.Text + "%'", con);
        DS = new DataSet();
        DA.Fill(DS, "DoctorMaster");
        dgvDoctorMaster.DataSource = DS;
        dgvDoctorMaster.DataBind();
        con.Close();
    }
    protected void btnShow_Click(object sender, EventArgs e)
    {
        con.Open();
        cmd1 = new SqlCommand("Select *from DoctorMaster where DrID='" + txtSearch.Text + "'", con);


        dr1 = cmd1.ExecuteReader();
        if (dr1.HasRows)
        {
            while (dr1.Read())
            {

                txtDrID.Text = dr1["DrID"].ToString();
                txtDrName.Text = dr1["Name"].ToString();
                txtAge.Text = dr1["Age"].ToString();
                txtJoinDate.Text = dr1["JoinDate"].ToString();
                txtBirthDate.Text = dr1["BirthDate"].ToString();
                txtAddress.Text = dr1["Address"].ToString();
                txtMobileNo.Text = dr1["MobileNo"].ToString();
                txtEmail.Text = dr1["Email"].ToString();
            }
            dr1.Close();
        }
        con.Close();
    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        con.Open();
        if (rbMale.Checked == true)
        {
            rbtn = "M";

        }
        else
        {
            rbtn = "F";

        }
        cmd = new SqlCommand("update DoctorMaster  set  Name='" + txtDrName.Text + "',Gender='"+
            rbtn+ "',Age='" + txtAge.Text + "',Specialization='" + ddlSpeci.SelectedItem + "', JoinDate='"+
            txtJoinDate.Text + "',BirthDate='" + txtBirthDate.Text + "',Address='" + txtAddress.Text + "',MobileNo='"
            + txtMobileNo.Text + "',Email='" + txtEmail.Text + "'  where   DrID ='" + txtSearch.Text + "'", con);
        cmd.ExecuteNonQuery();
        // Response.Write("<script LANGUAGE='Javascript' >alert('Data Updated')</script>");
        DA = new SqlDataAdapter("Select *from DoctorMaster Where DrID='" + txtSearch.Text + "'", con);
        DS = new DataSet();
        DA.Fill(DS, "DoctorMaster");
        dgvDoctorMaster.DataSource = DS;
        dgvDoctorMaster.DataBind();
        txtSearch.Text = "";
        txtAddress.Text = "";
        txtAge.Text = "";
        txtBirthDate.Text = "";
        txtDrID.Text = "";
        txtDrName.Text = "";
        txtEmail.Text = "";
        txtJoinDate.Text = "";
        txtMobileNo.Text = "";

        txtDrID.Focus();


        con.Close();
    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        con.Open();
        cmd = new SqlCommand("delete from DoctorMaster where DrID='" + txtSearch.Text + "'", con);
        cmd.ExecuteNonQuery();
        DA = new SqlDataAdapter("Select *from DoctorMaster ", con);
        DS = new DataSet();
        DA.Fill(DS, "DoctorMaster");
        dgvDoctorMaster.DataSource = DS;
        dgvDoctorMaster.DataBind();
        txtSearch.Text = "";
        con.Close();
        // Response.Write("<script LANGUAGE='Javascript' >alert('Data Deleted')</script>");
    }
    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomeAdmin.aspx");
    }
}