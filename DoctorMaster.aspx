<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="DoctorMaster.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cpmAdminMaster" Runat="Server">
<table border="2" style="background-color: #FFFFFF">
<tr><td align="center" colspan="4" style="font-family: 'Arial Black'; font-size: 30px">Doctor Master</td></tr>
<tr height="15px"><td colspan="4"></td></tr>
<tr>
<td><b>Dr_ID</b></td>
<td><asp:TextBox runat="server" ID="txtDrID" ReadOnly="true"/></td>
<td><b>Join Date</b></td>
<td><asp:TextBox runat="server" ID="txtJoinDate" /></td>
</tr>
<tr height="15px"><td colspan="4"></td></tr>
<tr>
<td><b>Dr_Name</b></td>
<td><asp:TextBox runat="server" ID="txtDrName" /></td>
<td><b>Birth Date</b></td>
<td><asp:TextBox runat="server" ID="txtBirthDate" /></td>
</tr>
<tr height="15px"><td colspan="4"></td></tr>
<tr>
<td><b>Gender</b></td>
<td><asp:RadioButton ID="rbMale" runat="server" Text="Male" GroupName="choice"  Font-Bold="true"/>
       <asp:RadioButton ID="rbFemale" runat="server" Text="Female" GroupName="choice"  Font-Bold="true"/>
<td><b>Address</b></td>
<td><asp:TextBox runat="server" ID="txtAddress" TextMode="MultiLine"/></td>
</tr>
<tr height="15px"><td colspan="4"></td></tr>
<tr>
<td><b>Age</b></td>
<td><asp:TextBox runat="server" ID="txtAge" /></td>
<td><b>MobileNo</b></td>
<td><asp:TextBox runat="server" ID="txtMobileNo" /></td>
</tr>
<tr height="15px"><td colspan="4"></td></tr>
<tr>
<td><b>Specification</b></td>
<td> <asp:DropDownList ID="ddlSpeci" runat="server" Width="154px">
            <asp:ListItem>----Select----</asp:ListItem>
            <asp:ListItem>General</asp:ListItem>
            <asp:ListItem>Cardiology</asp:ListItem>
            <asp:ListItem>Neurology</asp:ListItem>
            <asp:ListItem>Nephrology</asp:ListItem>
            <asp:ListItem>Opthalmology</asp:ListItem>
        </asp:DropDownList></td>
<td><b>Email</b></td>
<td><asp:TextBox runat="server" ID="txtEmail" /></td>
</tr>
<tr height="15px"><td colspan="4"></td></tr>
<tr>
<td colspan="4" align="center">
<asp:Button runat="server" ID="btnSubmit" Text="Submit" Font-Bold="true" 
        onclick="btnSubmit_Click" />
<asp:Button runat="server" ID="btnUpdate" Text="Update" Font-Bold="true" 
        onclick="btnUpdate_Click" />
<asp:Button runat="server" ID="btnDelete" Text="Delete" Font-Bold="true" 
        onclick="btnDelete_Click"/>
<asp:Button runat="server" ID="btnCancel" Text="Cancel" Font-Bold="true" 
        onclick="btnCancel_Click" />
<asp:Button runat="server" ID="btnBack" Text="Back" Font-Bold="true" 
        onclick="btnBack_Click" />
</td>
</tr>
<tr height="15px"><td colspan="4"></td></tr>
<tr>
<td colspan="4">
<asp:Button runat="server" ID="btnSearch" Text="Search" Font-Bold="true" 
        onclick="btnSearch_Click"/>
<asp:TextBox runat="server" ID="txtSearch" />
<asp:Button runat="server" ID="btnShow" Text="Show" Font-Bold="true" 
        onclick="btnShow_Click"  /> 
</td>
</tr>
<tr height="15px"><td colspan="4"></td></tr>
<tr>
<td colspan="4">
<div style="border-style:none; width:550px; height:70px; overflow:scroll">
<asp:DataGrid runat="server" ID="dgvDoctorMaster" /></div>
</td>
</tr>
</table>

</asp:Content>

