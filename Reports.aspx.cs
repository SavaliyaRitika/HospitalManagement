using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomeAdmin.aspx");
    }
    protected void btnDoctor_Click(object sender, EventArgs e)
    {
        Response.Redirect("DoctorReport.aspx");
    }
    protected void btnMedicine_Click(object sender, EventArgs e)
    {
        Response.Redirect("MedicineReport.aspx");
    }
    protected void btnPatient_Click(object sender, EventArgs e)
    {
        Response.Redirect("PatientReport.aspx");
    }
    protected void btnWard_Click(object sender, EventArgs e)
    {
        Response.Redirect("WardReport.aspx");
    }
    protected void btnDischarge_Click(object sender, EventArgs e)
    {
        Response.Redirect("DischargeReport.aspx");
    }
}