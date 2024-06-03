<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.master" AutoEventWireup="true" CodeFile="HomeMain.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphMainMaster" Runat="Server">
      <table>
      <tr style=" height: 200px">
      <td>
      </td>
      </tr>
<tr>
<td style="width: 10px"  >
</td>
<td >
<asp:BulletedList runat="server" ID="blLine1" Font-Bold="True" 
        Font-Names="Lucida Fax"  Font-Size="Large">
    <asp:ListItem>Registration must be Important..</asp:ListItem>
     <asp:ListItem> After Registration Complete to use this Site..</asp:ListItem>
    </asp:BulletedList>
    </td>
    </tr>
    <tr  align="center">
    <td style="width: 10px"  >
</td>
    <td >

<asp:Button runat="server" ID="btnRegistration" Text="Registration" 
        Font-Bold="True" onclick="btnRegistration_Click"  />
<asp:Button runat="server" ID="btnLogin" Text="Login" Font-Bold="True" 
            onclick="btnLogin_Click"  />

</td>
</tr>
</table>
</asp:Content>

