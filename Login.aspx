<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphMainMaster" Runat="Server">
<table><tr height="70px"><td></td></tr></table>
<table border="2">
<tr><td><table><tr><td>
<asp:Image runat="server" ID="imgLoginLogo" ImageUrl="photos/LoginLogo.jpeg"/>
</td><td>
<b><i><h1><asp:Label runat="server" ID="lblRfTitle" Text="Login Form" ForeColor="#333300" /></h1></i></b>
</td></tr></table></td></tr>
<tr><td>
<table border="1"><tr><td >
 <b> Usertype</b></td><td><asp:DropDownList ID="ddlist1" runat="server" style="margin-left: 0px" Width="333px">
            <asp:ListItem>Usertype</asp:ListItem>
            <asp:ListItem>Admin</asp:ListItem>
            <asp:ListItem>Client</asp:ListItem>
            </asp:DropDownList>
</td></tr>
<tr><td height="7px" colspan="2"></td></tr>
<tr><td><b>UserName</b></td><td><asp:TextBox runat="server" ID="txtUserName" /></td></tr>
<tr><td height="7px" colspan="2"></td></tr>
<tr><td><b>Password</b></td><td><asp:TextBox runat="server" ID="txtPass" TextMode="Password" /></td></tr>
<tr><td height="7px" colspan="2"></td></tr>
<tr><td colspan="2" align="center"><asp:Button ID="btnSubmit" runat="server" 
        Text="Submit" Font-Bold="true" onclick="btnSubmit_Click" /> 
<asp:Button ID="btnCancel" runat="server" Text="Cancle" Font-Bold="true" onclick="btnCancel_Click" />
<asp:Button ID="btnBack" runat="server" Text="Back" Font-Bold="true" 
        onclick="btnBack_Click" /></td></tr>
</table></td></tr></table>

</asp:Content>

