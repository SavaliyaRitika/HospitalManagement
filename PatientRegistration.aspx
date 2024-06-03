<%@ Page Title="" Language="C#" MasterPageFile="~/ClientMaster.master" AutoEventWireup="true" CodeFile="PatientRegistration.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphClientMaster" Runat="Server">
<table border="2" style="background-color: #FFFFFF">
<tr><td align="center" colspan="4" style="font-family: 'Arial Black'; font-size: 30px">Patient Registration</td></tr>
<tr height="15px"><td colspan="4"></td></tr>
<tr>
<td><b>ID</b></td>
<td><asp:TextBox ID="txtid" runat="server"  ReadOnly="True" /></td>
<td><b>Address</b></td>
<td><asp:TextBox ID="txtAddress" runat="server" TextMode="MultiLine" /></td>
</tr>
<tr height="15px"><td colspan="4"></td></tr>
<tr>
<td><b>SurName</b></td>
<td><asp:TextBox ID="txtSurName" runat="server" /></td>
<td><b>MobileNo</b></td>
<td><asp:TextBox ID="txtMobileNo" runat="server" /></td>
</tr>
<tr height="15px"><td colspan="4"></td></tr>
<tr>
<td><b>Name</b></td>
<td><asp:TextBox ID="txtName" runat="server" /></td>
<td><b>EmailId</b></td>
<td><asp:TextBox ID="txtEmailId" runat="server"/></td>
</tr>
<tr height="15px"><td colspan="4"></td></tr>
<tr>
<td><b>FatherName</b></td>
<td><asp:TextBox ID="txtFatherName" runat="server" /></td>
<td><b>Registration Date</b></td>
<td><asp:TextBox ID="txtRegistrationDate" runat="server"/></td>
</tr>
<tr height="15px"><td colspan="4"></td></tr>
<tr>
<td><b>Age</b></td>
<td><asp:TextBox ID="txtAge" runat="server" /></td>
<td><b>Department</b></td>
<td>  <asp:DropDownList ID="ddlDepart" runat="server" Width="154px">     
     <asp:ListItem>----Select----</asp:ListItem>
          <asp:ListItem>Special</asp:ListItem>
            <asp:ListItem>Gerenal</asp:ListItem>
        </asp:DropDownList></td>
</tr>
<tr height="15px"><td colspan="4"></td></tr>
<tr>
<td><b>Gender</b></td>
<td><asp:RadioButton ID="rbMale" runat="server" Text="Male" GroupName="choice"  Font-Bold="true"/>
       <asp:RadioButton ID="rbFemale" runat="server" Text="Female" GroupName="choice"  Font-Bold="true"/>
<td><b>Assign doctor</b></td>
<td><asp:DropDownList ID="ddlDoctor" runat="server" Width="154px" AutoPostBack="true"> </asp:DropDownList></td>
</tr>
<tr height="15px"><td colspan="4"></td></tr>
<tr>
<td colspan="4" align="center">
<asp:Button runat="server" ID="btnSubmit" Text="Submit" Font-Bold="true" 
        onclick="btnSubmit_Click" />
<asp:Button runat="server" ID="btnCancel" Text="Cancel" Font-Bold="true" 
        onclick="btnCancel_Click1" />
<asp:Button runat="server" ID="btnBack" Text="Back" Font-Bold="true" 
        onclick="btnBack_Click"  />
</td>
</tr>
</table>
</asp:Content>

