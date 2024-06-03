using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ClientMaster : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btbHome_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomeClient.aspx");
    }

    protected void btnPatientRegistration_Click(object sender, EventArgs e)
    {
        Response.Redirect("PatientRegistration.aspx");
    }
    protected void btnContactUs_Click(object sender, EventArgs e)
    {
        Response.Redirect("ContactUsH.aspx");
    }
    protected void btnAboutUs_Click(object sender, EventArgs e)
    {
        Response.Redirect("AboutUsH.aspx");
    }

    protected void btnLogOut_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomeMain.aspx");
    }
    protected void btnFeedback_Click(object sender, EventArgs e)
    {
        Response.Redirect("FeedbackClient.aspx");
    }
    protected void btnMedicine_Click(object sender, EventArgs e)
    {
        Response.Redirect("MedicineDetail.aspx");
    }
    protected void btnMedicine_Click1(object sender, EventArgs e)
    {
        Response.Redirect("MedicineDetail.aspx");
    }
    protected void btnDoctor_Click1(object sender, EventArgs e)
    {
        Response.Redirect("DoctorDetail.aspx");
    }
}
