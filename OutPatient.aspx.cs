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
        string qry = "select max(ID) from PatientRegistration";
        cmd = new SqlCommand(qry, con);
        SqlDataReader dr = cmd.ExecuteReader();
        dr.Read();
        int cid = Convert.ToInt32(dr[0]);
        cid++;
        txtid.Text = Convert.ToString(cid);
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
        txtid.Text = "";
        txtName.Text = "";
        txtSurName.Text = "";
        txtFatherName.Text = "";
        txtAddress.Text = "";
        txtAge.Text = "";
        txtEmailId.Text = "";
        txtMobileNo.Text = "";
        txtRegistrationDate.Text = "";
        //  txtAssigndoctor.Text = "";
        txtid.Focus();
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        cmd = new SqlCommand("Select * from  PatientRegistration  Where  ID='" + txtid.Text + "'", con);
        SqlDataReader dr;
        con.Open();
        dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            Response.Write("<script LANGUAGE='Javascript' >alert('Sorry....,Duplicate Data...')</script>");
            txtid.Text = "";
            txtName.Text = "";
            txtSurName.Text = "";
            txtFatherName.Text = "";
            txtAddress.Text = "";
            txtAge.Text = "";
            txtEmailId.Text = "";
            txtMobileNo.Text = "";
            txtRegistrationDate.Text = "";
            //  txtAssigndoctor.Text = "";
            txtid.Focus();
            con.Close();

        }

        else
        {

            if (txtid.Text == "" ||
           txtName.Text == "" ||
           txtSurName.Text == "" ||
           txtFatherName.Text == "" ||
           txtAddress.Text == "" ||
           txtAge.Text == "" ||
           txtEmailId.Text == "" ||
           txtMobileNo.Text == "" ||
           txtRegistrationDate.Text == "")
            {
                Response.Write("<script LANGUAGE='Javascript' >alert('Empty field not allowed....')</script>");

            }
            else
            {

                //con.Open();

                string rbtn;

                if (rbMale.Checked == true)
                {
                    rbtn = "M";

                }
                else
                {
                    rbtn = "F";

                }


                cmd = new SqlCommand("Insert into PatientRegistration(ID,SurName,Name,FatherName,Age,Gender,Address,MobileNo,EmailID,RegistrationDate,Department,AssignDoctor) Values('" +
                    txtid.Text + "','" + txtSurName.Text + "',  '"
                    + txtName.Text + "','" + txtFatherName.Text + "','" + txtAge.Text + "','" + rbtn + "','" + txtAddress.Text + "','"
                    + txtMobileNo.Text + "','" + txtEmailId.Text + "','" + txtRegistrationDate.Text + "','"
                    + ddlDepart.SelectedItem + "','" + ddlDoctor.SelectedItem + "')", con);



                dr.Close();
                cmd.ExecuteNonQuery();
                //  Response.Write("<script LANGUAGE='Javascript' >alert('Data Added')</script>");
                DA = new SqlDataAdapter("Select ID,SurName,Name,FatherName,Age,Gender,Address,MobileNo,EmailID,RegistrationDate,Department,AssignDoctor from PatientRegistration", con);
                DS = new DataSet();
                DA.Fill(DS, "PatientRegistration");
                dgvOutPatientMaster.DataSource = DS;
                dgvOutPatientMaster.DataBind();
                txtid.Text = "";
                txtName.Text = "";
                txtSurName.Text = "";
                txtFatherName.Text = "";
                txtAddress.Text = "";
                txtAge.Text = "";
                txtEmailId.Text = "";
                txtMobileNo.Text = "";
                txtRegistrationDate.Text = "";
                //  txtAssigndoctor.Text = "";
                txtid.Focus();
                con.Close();
            }
        }
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        con.Open();

        cmd = new SqlCommand("update PatientRegistration  set SurName='" +
            txtSurName.Text + "', Name='" + txtName.Text + "',FatherName='" + txtFatherName.Text + "', Age='" + txtAge.Text + "',Address='" +
                txtAddress.Text + "',MobileNo='" + txtMobileNo.Text + "',EmailID='"
            + txtEmailId.Text + "',RegistrationDate='" + txtRegistrationDate.Text + "',Department='" +
            ddlDepart.SelectedItem + "', AssignDoctor='"+ddlDoctor.SelectedItem+"' where ID ='" + txtSearch.Text + "'", con);
        cmd.ExecuteNonQuery();
        // Response.Write("<script LANGUAGE='Javascript' >alert('Data Updated')</script>");
        DA = new SqlDataAdapter("Select ID,SurName,Name,FatherName,Age,Gender,Address,MobileNo,EmailID,RegistrationDate,Department,AssignDoctor from PatientRegistration Where  ID='" + txtSearch.Text + "'", con);
        DS = new DataSet();
        DA.Fill(DS, "PatientRegistration");
        dgvOutPatientMaster.DataSource = DS;
        dgvOutPatientMaster.DataBind();
        txtSearch.Text = "";
        txtid.Text = "";
        txtName.Text = "";
        txtSurName.Text = "";
        txtFatherName.Text = "";
        txtAddress.Text = "";
        txtAge.Text = "";
        txtEmailId.Text = "";
        txtMobileNo.Text = "";
        txtRegistrationDate.Text = "";
        //  txtAssigndoctor.Text = "";
        txtid.Focus();

        
        con.Close();
    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        con.Open();
        cmd = new SqlCommand("delete from PatientRegistration where ID='" + txtSearch.Text + "'", con);
        cmd.ExecuteNonQuery();

        DA = new SqlDataAdapter("Select ID,SurName,Name,FatherName,Age,Gender,Address,MobileNo,EmailID,RegistrationDate,Department,AssignDoctor from PatientRegistration", con);
        DS = new DataSet();
        DA.Fill(DS, "PatientRegistration");
        dgvOutPatientMaster.DataSource = DS;
        dgvOutPatientMaster.DataBind();
        txtSearch.Text = "";
        con.Close();
        // Response.Write("<script LANGUAGE='Javascript' >alert('Data Deleted')</script>");
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        con.Open();
       
        DS = new DataSet();
        DA = new SqlDataAdapter("Select ID,SurName,Name,FatherName,Age,Gender,Address,MobileNo,EmailID,RegistrationDate,Department,AssignDoctor from PatientRegistration Where Name Like  '%" + txtSearch.Text + "%'", con);
        DA.Fill(DS, "PatientRegistration");
        dgvOutPatientMaster.DataSource = DS;
        dgvOutPatientMaster.DataBind();
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

                txtid.Text = dr1["ID"].ToString();
                txtName.Text = dr1["Name"].ToString();
                txtSurName.Text = dr1["SurName"].ToString();
                txtFatherName.Text = dr1["FatherName"].ToString();
                txtAge.Text = dr1["Age"].ToString();
                txtRegistrationDate.Text = dr1["RegistrationDate"].ToString();
                txtAddress.Text = dr1["Address"].ToString();
                txtMobileNo.Text = dr1["MobileNo"].ToString();
                txtEmailId.Text = dr1["EmailID"].ToString();
            }
            dr1.Close();
        }
        con.Close();
    }
    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomeAdmin.aspx");
    }
}