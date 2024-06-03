<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="DischargeMaster.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cpmAdminMaster" Runat="Server">
<table border="2" style="background-color: #FFFFFF">
<tr><td align="center" colspan="2" style="font-family: 'Arial Black'; font-size: 30px">Discharge Master</td></tr>
<tr height="15px"><td colspan="2"></td></tr>
<tr>
<td><b>Discharge No</b></td>
<td><asp:TextBox runat="server" ID="txtDisNO" /></td>
</tr>
<tr height="15px"><td colspan="2"></td></tr>
<tr>
<td><b>Patient Name</b></td>
<td><asp:TextBox runat="server" ID="txtName" /></td>
</tr>
<tr height="15px"><td colspan="2"></td></tr>
<tr>
<td><b>Discharge Date</b></td>
<td><asp:TextBox runat="server" ID="txtDisDate" /></td>
</tr>
<tr height="15px"><td colspan="2"></td></tr>
<tr>
<td><b>Patient Type</b></td>
<td><asp:DropDownList ID="ddlPatientType" runat="server" Width="170px" >
<asp:ListItem>PatientType</asp:ListItem>
<asp:ListItem>In-Patient</asp:ListItem>
<asp:ListItem>Out-Patient</asp:ListItem>
</asp:DropDownList></td>
</tr>
<tr height="15px"><td colspan="2"></td></tr>
<tr>
<td><b>Charge</b></td>
<td><asp:TextBox runat="server" ID="txtCharge" /></td>
</tr>
<tr height="15px" ><td colspan="2"></td></tr>
<tr>
<td colspan="2" align="center">
<asp:Button runat="server" ID="btnSubmit" Text="Submit" Font-Bold="true" 
        onclick="btnSubmit_Click" />
<asp:Button runat="server" ID="btnUpdate" Text="Update" Font-Bold="true" onclick="btnUpdate_Click"/>
<asp:Button runat="server" ID="btnDelete" Text="Delete" Font-Bold="true" onclick="btnDelete_Click" 
       />
<asp:Button runat="server" ID="btnCancel" Text="Cancel" Font-Bold="true" 
        onclick="btnCancel_Click" />
<asp:Button runat="server" ID="btnBack" Text="Back" Font-Bold="true" 
        onclick="btnBack_Click" />
</td>
</tr>
<tr height="15px"><td colspan="2"></td></tr>
<tr>
<td colspan="2">
<asp:Button runat="server" ID="btnSearch" Text="Search" Font-Bold="true" onclick="btnSearch_Click" 
        />
<asp:TextBox runat="server" ID="txtSearch" />
<asp:Button runat="server" ID="btnShow" Text="Show" Font-Bold="true" onclick="btnShow_Click" 
          /> 
</td>
</tr>
<tr height="15px"><td colspan="2"></td></tr>
<tr>
<td colspan="2">
<div style="border-style:none; width:400px; height:70px; overflow:scroll">
<asp:DataGrid runat="server" ID="dgvDischargeMaster" /></div>
</td>
</tr>
</table>
</asp:Content>

