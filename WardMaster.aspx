<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="WardMaster.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cpmAdminMaster" Runat="Server">
<table border="2" style="background-color: #FFFFFF">
<tr><td align="center" colspan="2" style="font-family: 'Arial Black'; font-size: 30px">Ward Master</td></tr>
<tr height="20px"><td colspan="2"></td></tr>
<tr>
<td><b>SrNo</b></td>
<td><asp:TextBox runat="server" ID="txtSrNo" /></td>
</tr>
<tr height="20px"><td colspan="2"></td></tr>
<tr>
<td><b>WardType</b></td>
<td><asp:DropDownList ID="ddlWardType" runat="server" Width="170px" >
<asp:ListItem>WardType</asp:ListItem>
<asp:ListItem>General Ward</asp:ListItem>
<asp:ListItem>Special Ward</asp:ListItem>
</asp:DropDownList></td>
</tr>
<tr height="20px"><td colspan="2"></td></tr>
<tr>
<td><b>WardNo</b></td>
<td><asp:TextBox runat="server" ID="txtWardNo" /></td>
</tr>
<tr height="20px"><td colspan="2"></td></tr>
<tr>
<td><b>BedNo</b></td>
<td><asp:TextBox runat="server" ID="txtBedNo" /></td>
</tr>
<tr height="20px"><td colspan="2"></td></tr>
<tr>
<td><b>PatientName</b></td>
<td>
<asp:TextBox runat="server" ID="txtName"/>
</td>
</tr>
<tr height="20px"><td colspan="2"></td></tr>
<tr>
<td colspan="2" align="center">
<asp:Button runat="server" ID="btnSubmit" Text="Submit" Font-Bold="true" 
        onclick="btnSubmit_Click" />
<asp:Button runat="server" ID="btnUpdate" Text="Update" Font-Bold="true" 
        onclick="btnUpdate_Click" />
<asp:Button runat="server" ID="btnDelete" Text="Delete" Font-Bold="true" 
        onclick="btnDelete_Click" />
<asp:Button runat="server" ID="btnCancel" Text="Cancel" Font-Bold="true" 
        onclick="btnCancel_Click"/>
<asp:Button runat="server" ID="btnBack" Text="Back" Font-Bold="true" 
        onclick="btnBack_Click" />
</td>
</tr>
<tr style="height: 20px"><td colspan="2"></td></tr>
<tr>
<td colspan="2">
<asp:Button runat="server" ID="btnSearch" Text="Search" Font-Bold="true" 
        onclick="btnSearch_Click" />
<asp:TextBox runat="server" ID="txtSearch" />
<asp:Button runat="server" ID="btnShow" Text="Show" Font-Bold="true" 
        onclick="btnShow_Click" /> 
</td>
</tr>
<tr style="height: 20px"><td colspan="2"></td></tr>
<tr>
<td colspan="2">
<div style="border-style:none; width:400px; height:70px; overflow:scroll">
<asp:DataGrid runat="server" ID="dgvWardMaster" />
</td>
</tr>
</table>
</asp:Content>

