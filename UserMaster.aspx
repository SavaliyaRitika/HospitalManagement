<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="UserMaster.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cpmAdminMaster" Runat="Server">
<table border="2" style="background-color: #FFFFFF">
<tr><td align="center" colspan="2" style="font-family: 'Arial Black'; font-size: 30px">User Master</td></tr>
<tr style="height: 10px"><td colspan="2"></td></tr>
<tr>
<td><b>UserID</b></td>
<td><asp:TextBox runat="server" ID="txtUserId"  ReadOnly="True" /></td>
</tr>
<tr style="height: 10px"><td colspan="2"></td></tr>
<tr>
<td><b>UserName</b></td>
<td><asp:TextBox runat="server" ID="txtUserName" /></td>
</tr>
<tr style="height: 10px"><td colspan="2"></td></tr>
<tr>
<td><b>UserType</b></td>
<td>
<asp:DropDownList ID="ddlUserType" runat="server" Width="170px" >
<asp:ListItem>UserType</asp:ListItem>
<asp:ListItem>Admin</asp:ListItem>
<asp:ListItem>Client</asp:ListItem>
</asp:DropDownList></td>
</tr>
<tr style="height: 10px"><td colspan="2"></td></tr>
<tr>
<td><b>Password</b></td>
<td><asp:TextBox runat="server" ID="txtPassword"  TextMode="Password"/></td>
</tr>
<tr style="height: 10px"><td colspan="2"></td></tr>
<tr>
<td><b>Re-Enter Password</b></td>
<td><asp:TextBox runat="server" ID="txtRePassword"  TextMode="Password"/>

</td>
</tr>
<tr style="height: 10px"><td colspan="2"></td></tr>
<tr>
<td><b>UserCreation Date </b></td>
<td><asp:TextBox runat="server" ID="txtUserCDate" /></td>
</tr>
<tr style="height: 10px"><td colspan="2"><asp:CompareValidator runat="server" ID="cvPass" ControlToCompare="txtPassword" 
ControlToValidate="txtRePassword" ForeColor="red"
ErrorMessage="Password and Re-Enter Password are Must be same" /></td></tr>
<tr>
<td colspan="2" align="center">
<asp:Button runat="server" ID="btnSubmit" Text="Submit" Font-Bold="true" 
        onclick="btnSubmit_Click"/>
<asp:Button runat="server" ID="btnUpdate" Text="Update" Font-Bold="true" 
        onclick="btnUpdate_Click"/>
<asp:Button runat="server" ID="btnDelete" Text="Delete" Font-Bold="true" 
        onclick="btnDelete_Click"/>
<asp:Button runat="server" ID="btnCancel" Text="Cancel" Font-Bold="true" 
        onclick="btnCancel_Click"/>
<asp:Button runat="server" ID="btnBack" Text="Back" Font-Bold="true" 
        onclick="btnBack_Click"/>
</td>
</tr>
<tr style="height: 10px"><td colspan="2"></td></tr>
<tr>
<td colspan="2">
<asp:Button runat="server" ID="btnSearch" Text="Search" Font-Bold="true" 
        onclick="btnSearch_Click"/>
<asp:TextBox runat="server" ID="txtSearch" />
<asp:Button runat="server" ID="btnShow" Text="Show" Font-Bold="true" 
        onclick="btnShow_Click" /> 
</td>
</tr>
<tr style="height: 10px"><td colspan="2"></td></tr>
<tr>
<td colspan="2">
<div style="border-style:none; width:400px; height:70px; overflow:scroll">
<asp:DataGrid runat="server" ID="dgvUserMaster" /></div>
</td>
</tr>
</table>


</asp:Content>

