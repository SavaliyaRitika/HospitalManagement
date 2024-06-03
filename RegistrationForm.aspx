<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.master" AutoEventWireup="true" CodeFile="RegistrationForm.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphMainMaster" Runat="Server">
<table  align="left " border="2" style="background-color: #FFFFFF">
<tr>
<td>
<table>
<tr>
<td>
<asp:Image ID="imgRagiLogo" runat="server" ImageUrl="photos/RegiLogo.jpeg"/>
</td>
<td>
<b><i><h1><asp:Label runat="server" ID="lblRfTitle" Text="Registration Form"  ForeColor="#333300"  /></h1></i></b>
</td>
</tr>
</td> 
</tr>    
</table>
<tr>
<td>
<table border="2">
<tr><td height="7px" colspan="2"></td></tr>
<tr>
<td><b>UserID</b></td>
<td>
<asp:TextBox runat="server" ID="txtUserID" ReadOnly="True" />
</td>
</tr>
<tr><td height="7px" colspan="2"></td></tr>
<tr>
<td><b>UserName</b></td>
<td>
<asp:TextBox runat="server" ID="txtUserName" />

</td>
</tr>
<tr><td height="7px" colspan="2"></td></tr>
<tr>
<td><b>BirthDate</b></td>
<td>
<asp:TextBox runat="server" ID="txtBirthDate" />
</td>
</tr>

<tr><td height="7px" colspan="2"></td></tr>
<tr>
<td><b>Email</b></td>
<td>
<asp:TextBox runat="server" ID="txtEmail" />
</td>
</tr>
<tr><td height="7px" colspan="2"></td></tr>
<tr>
<td><b>MobileNo</b></td>
<td>
<asp:TextBox runat="server" ID="txtMobileNo" />
</td>
</tr>
<tr><td height="7px" colspan="2"></td></tr>
<tr>
<td><b>Password</b></td>
<td>
<asp:TextBox runat="server" ID="txtPassword" TextMode="Password"/>
</td>
</tr>
<tr><td height="7px" colspan="2"></td></tr>
<tr>
<td><b>Confirm_Password</b></td>
<td>
<asp:TextBox runat="server" ID="txtCPassword" TextMode="Password" />
</td>
</tr>
<tr><td height="7px" colspan="2">
<asp:CompareValidator runat="server" ID="cvPass" ControlToCompare="txtPassword" 
ControlToValidate="txtCPassword" ForeColor="red"
ErrorMessage="Password and Confirm Password are Must be same" />
</td></tr>
<tr>
<td colspan="2" align="center">
<asp:Button runat="server" ID="btnSubmit" Text="Submit" Font-Bold="true" 
        onclick="btnSubmit_Click" />
<asp:Button runat="server" ID="btnCancel" Text="Cancel" Font-Bold="true" 
        onclick="btnCancel_Click1"  />
<asp:Button runat="server" ID="btnBack" Text="Back" Font-Bold="true" 
        onclick="btnBack_Click" />
</td>
</tr>
   </table>
</td>
</tr>
</table>

</asp:Content>

