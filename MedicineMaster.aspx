<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="MedicineMaster.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cpmAdminMaster" Runat="Server">
<table border="2" style="background-color: #FFFFFF">
<tr><td align="center" colspan="2" style="font-family: 'Arial Black'; font-size: 30px">Medicine Master</td></tr>
<tr height="15px"><td colspan="2"></td></tr>
<tr>
<td><b>SrNo</b></td>
<td><asp:TextBox runat="server" ID="txtSrNO" ReadOnly="true"/></td>
</tr>
<tr height="15px"><td colspan="2"></td></tr>
<tr>
<td><b>Generic Name</b></td>
<td><asp:TextBox runat="server" ID="txtGenericName" TextMode="MultiLine"/></td>
</tr>
<tr height="15px"><td colspan="2"></td></tr>
<tr>
<td><b>Brand Name</b></td>
<td><asp:TextBox runat="server" ID="txtBrandName" TextMode="MultiLine"/></td>
</tr>
<tr height="15px"><td colspan="2"></td></tr>
<tr>
<td><b>Price</b></td>
<td><asp:TextBox runat="server" ID="txtPrice"/></td>
</tr>
<tr height="15px"><td colspan="2"></td></tr>
<tr>
<td><b>Uses</b></td>
<td><asp:TextBox runat="server" ID="txtUses" TextMode="MultiLine"/></td>
</tr>
<tr height="15px"><td colspan="2"></td></tr>
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
<tr style="height: 15px"><td colspan="2"></td></tr>
<tr>
<td colspan="2">
<asp:Button runat="server" ID="btnSearch" Text="Search" Font-Bold="true" 
        onclick="btnSearch_Click" />
<asp:TextBox runat="server" ID="txtSearch" />
<asp:Button runat="server" ID="btnShow" Text="Show" Font-Bold="true" 
        onclick="btnShow_Click" /> 
</td>
</tr>
<tr style="height: 15px"><td colspan="2"></td></tr>
<tr>
<td colspan="2">
<div style="border-style:none; width:350px; height:70px; overflow:scroll">
<asp:DataGrid runat="server" ID="dgvMedicineMaster" />
</div>
</td>
</tr>
</table>
</asp:Content>

