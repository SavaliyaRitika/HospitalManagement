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
    string rbtn;
    string apppath = System.AppDomain.CurrentDomain.BaseDirectory;
    protected void Page_Load(object sender, EventArgs e)
    {
        con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=" + apppath + @"APP_Data\Database.mdf;Integrated Security=True; User Instance=True");
        con.Open();
        string qry = "select max(ID) from PatientRegistration";
        cmd = new SqlCommand(qry, con);
        SqlDataReader dr = cmd.ExecuteReader();
        dr.Read();
        int cid = Convert.ToInt32(dr[0]);
        cid++;
        txtID.Text = Convert.ToString(cid);
        dr.Close();
        con.Close();
        // Response.Write("<script LANGUAGE='Javascript' >alert('Database Connected')</script>");
        if (!Page.IsPostBack)
        {
            filldrop();
            ddlDoctor.Items.Insert(0, "...Select...");
        }
    }
    void filldrop()
    {
        con.Open();
        string qry = "select Name from DoctorMaster";
        SqlDataAdapter da = new SqlDataAdapter(qry, con);
        DataSet ds = new DataSet();
        da.Fill(ds, "DoctorMaster");
        ddlDoctor.DataSource = ds;
        ddlDoctor.DataTextField = "Name";
        ddlDoctor.DataBind();
        con.Close();
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        txtID.Text = "";
        txtSurName.Text = "";
        txtName.Text = "";
        txtFatherName.Text = "";
        txtAge.Text = "";
        txtAddress.Text = "";
        txtMobileNO.Text = "";
        txtReLativeNo.Text = "";
        txtSymtoms.Text = "";
        txtWardNo.Text = "";
        txtBedNo.Text = "";
        txtEmailID.Text = "";
        txtrd.Text = "";
        txtID.Focus();
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        cmd = new SqlCommand("Select * from  PatientRegistration  Where  ID='" + txtID.Text + "'", con);
        SqlDataReader dr;
        con.Open();
        dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            Response.Write("<script LANGUAGE='Javascript' >alert('Sorry....,Duplicate Data...')</script>");
            txtID.Text = "";
            txtSurName.Text = "";
            txtName.Text = "";
            txtFatherName.Text = "";
            txtAge.Text = "";
            txtAddress.Text = "";
            txtMobileNO.Text = "";
            txtReLativeNo.Text = "";
            txtSymtoms.Text = "";
            txtWardNo.Text = "";
            txtBedNo.Text = "";
            txtEmailID.Text = "";
            txtrd.Text = "";
            txtID.Focus();
            con.Close();

        }

        else
        {
            if (txtID.Text == "" ||
        txtSurName.Text == "" ||
        txtName.Text == "" ||
        txtFatherName.Text == "" ||
        txtAge.Text == "" ||
        txtAddress.Text == "" ||
        txtMobileNO.Text == "" ||
        txtReLativeNo.Text == "" ||
        txtSymtoms.Text == "" ||
        txtWardNo.Text == "" ||
        txtBedNo.Text == "" ||
        txtEmailID.Text == "" ||
        txtrd.Text == "")
            {
                Response.Write("<script LANGUAGE='Javascript' >alert('Empty field not allowed....')</script>");

            }
            else
            {
                //con.Open();

               

                if (rbMale.Checked == true)
                {
                    rbtn = "M";

                }
                else
                {
                    rbtn = "F";

                }


                cmd = new SqlCommand("Insert into PatientRegistration Values('" + txtID.Text + "','" + txtSurName.Text + "','" + txtName.Text + "','" + txtFatherName.Text + "','" +
                    txtAge.Text + "','" + rbtn + "','" + txtAddress.Text + "','" + txtMobileNO.Text + "','" + txtEmailID.Text + "','" + txtrd.Text + "','" + txtReLativeNo.Text
                    + "','" + txtSymtoms.Text + "','" + ddlDepart.SelectedItem + "','" + ddlDoctor.SelectedItem + "','" + txtWardNo.Text + "','" + txtBedNo.Text + "')", con);
               
                dr.Close();
                cmd.ExecuteNonQuery();
                //  Response.Write("<script LANGUAGE='Javascript' >alert('Data Added')</script>");
                DA = new SqlDataAdapter("Select *from PatientRegistration", con);
                DS = new DataSet();
                DA.Fill(DS, "PatientRegistration");
                dgvInPatientMaster.DataSource = DS;
                dgvInPatientMaster.DataBind();
                txtID.Text = "";
                txtSurName.Text = "";
                txtName.Text = "";
                txtFatherName.Text = "";
                txtAge.Text = "";
                txtAddress.Text = "";
                txtMobileNO.Text = "";
                txtReLativeNo.Text = "";
                txtSymtoms.Text = "";
                txtWardNo.Text = "";
                txtBedNo.Text = "";
                txtEmailID.Text = "";
                txtrd.Text = "";
                txtID.Focus();
                con.Close();
            }
        }
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        con.Open();
        DA = new SqlDataAdapter("Select *from PatientRegistration Where Name Like  '%" + txtSearch.Text + "%'", con);
        DS = new DataSet();
        DA.Fill(DS, "PatientRegistration");
        dgvInPatientMaster.DataSource = DS;
        dgvInPatientMaster.DataBind();
        con.Close();
    }
    protected void btnShow_Click(object sender, EventArgs e)
    {
        con.Open();
        cmd1 = new SqlCommand("Select *from PatientRegistration where ID='" + txtSearch.Text + "'", con);


        dr1 = cmd1.ExecuteReader();
        if (dr1.HasRows)
        {
            while (dr1.Read())
            {
                txtrd.Text = dr1["RegistrationDate"].ToString();
                txtID.Text = dr1["ID"].ToString();
                txtSurName.Text = dr1["SurName"].ToString();
                txtName.Text = dr1["Name"].ToString();
                txtFatherName.Text = dr1["FatherName"].ToString();
                txtAge.Text = dr1["Age"].ToString();
                txtSymtoms.Text = dr1["Symtoms"].ToString();
                txtReLativeNo.Text = dr1["RelativeMobileNo"].ToString();
                txtAddress.Text = dr1["Address"].ToString();
                txtMobileNO.Text = dr1["MobileNo"].ToString();
                txtEmailID.Text = dr1["EmailID"].ToString();
                txtWardNo.Text = dr1["WardNo"].ToString();
                txtBedNo.Text = dr1["BedNo"].ToString();
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
        cmd = new SqlCommand("update PatientRegistration  set SurName='" + txtSurName.Text
            + "', Name='" + txtName.Text + "',  FatherName='" + txtFatherName.Text + "', Age='" + txtAge.Text + "', Gender='" +
            rbtn + "' ,Address='" + txtAddress.Text + "',MobileNo='" + txtMobileNO.Text + "', EmailID='" + txtEmailID.Text
            + "', RegistrationDate='" + txtrd.Text + "',RelativeMobileNo='" + txtReLativeNo.Text + "',Symtoms='" + txtSymtoms.Text
            + "',  Department='" + ddlDepart.SelectedItem + "',AssignDoctor='" + ddlDoctor.SelectedItem + "', WardNo='" +
            txtWardNo.Text + "',BedNo='" + txtBedNo.Text + "'  where   ID ='" + txtSearch.Text + "'", con);
        cmd.ExecuteNonQuery();
        // Response.Write("<script LANGUAGE='Javascript' >alert('Data Updated')</script>");
        DA = new SqlDataAdapter("Select *from PatientRegistration Where ID='" + txtSearch.Text + "'", con);
         DS = new DataSet();
         DA.Fill(DS, "PatientRegistration");
         dgvInPatientMaster.DataSource = DS;
         dgvInPatientMaster.DataBind();
        txtSearch.Text = "";

        txtID.Text = "";
        txtSurName.Text = "";
        txtName.Text = "";
        txtFatherName.Text = "";
        txtAge.Text = "";
        txtAddress.Text = "";
        txtMobileNO.Text = "";
        txtReLativeNo.Text = "";
        txtSymtoms.Text = "";
        txtWardNo.Text = "";
        txtBedNo.Text = "";
        txtEmailID.Text = "";
        txtrd.Text = "";
        txtID.Focus();

        con.Close();
    
    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        con.Open();
        cmd = new SqlCommand("delete from PatientRegistration where ID='" + txtSearch.Text + "'", con);
        cmd.ExecuteNonQuery();
        DA = new SqlDataAdapter("Select *from PatientRegistration", con);
        DS = new DataSet();
        DA.Fill(DS, "PatientRegistration");
        dgvInPatientMaster.DataSource = DS;
        dgvInPatientMaster.DataBind();
        txtSearch.Text = "";
        con.Close();
    }
    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomeAdmin.aspx");
    }
}