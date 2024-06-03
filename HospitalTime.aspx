<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.master" AutoEventWireup="true" CodeFile="HospitalTime.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphMainMaster" Runat="Server">
<table border="0">
<tr><td width="400px"></td>
<td width="50px">
<asp:HyperLink ID="hplGelery" runat="server" NavigateUrl="~/Gelery.aspx">Gelery</asp:HyperLink></td>
    <td> <asp:HyperLink ID="hplRuls" runat="server" NavigateUrl="~/Rules.aspx" >Rules&Regulation</asp:HyperLink></td>
    <td> <asp:HyperLink ID="hpTime" runat="server" NavigateUrl="~/HospitalTime.aspx" >HospitalTime</asp:HyperLink></td>
         
</tr>
<tr><td height="0px"></td></tr>
</table>
<table><tr><td height="100px"></td></tr></table>
<table bgcolor="White">
<tr ><td style="width: 100px" d ></td></tr>
<tr>

<td style="font-family: 'Arial Narrow'; font-size: 31px; color: #FF0000;">
<b>24 Hours Services</b>
<br />Contact No : 02793251777
</td>
</tr>
<tr>
<td>
<asp:Image ID="imgAboutUs" runat="server" ImageUrl="photos/HospitalTime.jpeg" />
</td>
</tr>
</table>

</asp:Content>

