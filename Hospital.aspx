<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.master" AutoEventWireup="true" CodeFile="Hospital.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphMainMaster" Runat="Server">
<table border="0">
<tr><td width="400px"></td>
<td width="50px">
<asp:HyperLink ID="hplGelery" runat="server" NavigateUrl="~/Gelery.aspx">Gelery</asp:HyperLink></td>
    <td> <asp:HyperLink ID="hplRuls" runat="server" NavigateUrl="~/Rules.aspx" >Rules&Regulation</asp:HyperLink></td>
    <td> <asp:HyperLink ID="hpTime" runat="server" NavigateUrl="~/HospitalTime.aspx" >HospitalTime</asp:HyperLink></td>
</tr>
<tr><td height="400px"></td></tr>
</table>
    
</asp:Content>

