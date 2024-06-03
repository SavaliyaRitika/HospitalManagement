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
    //SqlCommand cmd1;
  //  DataSet DS;
  //  SqlDataAdapter DA;
   // SqlDataReader dr1;
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
            txtid.Focus();
           // con.Close();
            
        }

        else
        {
            if (txtid.Text == "" || txtName.Text == "" || txtSurName.Text == "" || txtFatherName.Text == "" || txtAddress.Text == "" ||
            txtAge.Text == "" || txtEmailId.Text == "" || txtMobileNo.Text == "" || txtRegistrationDate.Text == "")
            {
                Response.Write("<script LANGUAGE='Javascript' >alert('Empty field not allowed....')</script>");

            }
            else
            {
                dr.Close();


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
    protected void btnCancel_Click1(object sender, EventArgs e)
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
    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomeClient.aspx");
    }
}