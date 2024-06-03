<%@ Page Title="" Language="C#" MasterPageFile="~/ClientMaster.master" AutoEventWireup="true" CodeFile="FeedbackClient.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphClientMaster" Runat="Server">
<table border="2" style="background-color: #FFFFFF">
<tr><td align="center" colspan="2" style="font-family: 'Arial Black'; font-size: 30px">FeedBack</td></tr>
<tr height="20px"><td colspan="2"></td></tr>
<tr>
<td><b>Registration No</b></td>
<td><asp:TextBox runat="server" ID="txtRagistration"  ReadOnly="True" /></td>
</tr>
<tr height="20px"><td colspan="2"></td></tr>
<tr>
<td><b>Name</b></td>
<td><asp:TextBox runat="server" ID="txtName" /></td>
</tr>
<tr height="20px"><td colspan="2"></td></tr>
<tr>
<td><b>Contact No</b></td>
<td><asp:TextBox runat="server" ID="txtContactNo" /></td>
</tr>
<tr height="20px"><td colspan="2"></td></tr>
<tr>
<td><b>EmailID</b></td>
<td><asp:TextBox runat="server" ID="txtEmailID" /></td>
</tr>
<tr height="20px"><td colspan="2"></td></tr>
<tr>
<td><b>Message</b></td>
<td><asp:TextBox runat="server" ID="txtMessage" TextMode="MultiLine" /></td>
</tr>
<tr height="20px"><td colspan="2"></td></tr>
<tr>
<td colspan="2" align="center">
<asp:Button runat="server" ID="btnSubmit" Text="Submit" Font-Bold="true" 
        onclick="btnSubmit_Click" />
<asp:Button runat="server" ID="btnCancel" Text="Cancel" Font-Bold="true" 
        onclick="btnCancel_Click" />
<asp:Button runat="server" ID="btnBack" Text="Back" Font-Bold="true" 
        onclick="btnBack_Click" />
</td>
</tr>
</table>
</asp:Content>

