using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class AdminMaster : System.Web.UI.MasterPage
{

    protected void Page_Load(object sender, EventArgs e)
    {
    }
    protected void btbHome_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomeAdmin.aspx");
    }
    protected void btnUsermaster_Click(object sender, EventArgs e)
    {
        Response.Redirect("UserMaster.aspx");
    }
    protected void btnDoctormaster_Click(object sender, EventArgs e)
    {
        Response.Redirect("DoctorMaster.aspx");
    }
    protected void btnWardmaster_Click(object sender, EventArgs e)
    {
        Response.Redirect("WardMaster.aspx");
    }
    protected void btnDischargemaster_Click(object sender, EventArgs e)
    {
        Response.Redirect("DischargeMaster.aspx");
    }
    protected void btnMedicinemaster_Click(object sender, EventArgs e)
    {
        Response.Redirect("MedicineMaster.aspx");
    }
    protected void btnInPatientmaster_Click(object sender, EventArgs e)
    {
        Response.Redirect("InPatientMaster.aspx");
    }
    protected void btnOutPatientmaster_Click(object sender, EventArgs e)
    {
        Response.Redirect("OutPatient.aspx");
        
    }
    protected void btnLogOut_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomeMain.aspx");
    }
    protected void btnFeedback_Click(object sender, EventArgs e)
    {
        Response.Redirect("FeedBackDetail.aspx");
    }
    protected void btnReports_Click1(object sender, EventArgs e)
    {
        Response.Redirect("Reports.aspx");
    }
}
