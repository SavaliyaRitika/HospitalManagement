using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MainMaster : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btbHome_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomeMain.aspx");
    }
    protected void btnHospital_Click(object sender, EventArgs e)
    {
        Response.Redirect("Hospital.aspx");
    }
    protected void btnFacility_Click(object sender, EventArgs e)
    {
        Response.Redirect("Facilities.aspx");
    }
    protected void btnContactus_Click(object sender, EventArgs e)
    {
       Response.Redirect("ContactUs.aspx");                    
    }
    protected void btnAboutus_Click(object sender, EventArgs e)
    {
        Response.Redirect("AboutUs.aspx");
    }
}
