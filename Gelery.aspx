<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.master" AutoEventWireup="true" CodeFile="Gelery.aspx.cs" Inherits="Default2" %>

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
<table>

<tr>
<td>
 <asp:Image ID="imgGelery1" runat="server"  ImageUrl="photos/Gelery1.jpeg" height="150px" Width="290px"/>
</td>
<td>
 <asp:Image ID="imgGelery2" runat="server"  ImageUrl="photos/Gelery2.jpg" height="150px" Width="290px"/>
</td>
<td>
 <asp:Image ID="imgGelery3" runat="server"  ImageUrl="photos/Gelery3.jpeg" height="150px" Width="290px" />
</td>
<td>
 <asp:Image ID="imgGelery10" runat="server"  ImageUrl="photos/Gelery10.jpeg" height="150px" Width="290px" />
</td>
</tr>
<tr>
<td>
 <asp:Image ID="imgGelery4" runat="server"  ImageUrl="photos/Gelery4.jpeg" height="150px" Width="290px"/>
</td>
<td>
 <asp:Image ID="imgGelery5" runat="server"  ImageUrl="photos/Gelery5.jpg" height="150px" Width="290px"/>
</td>
<td>
 <asp:Image ID="imgGelery6" runat="server"  ImageUrl="photos/Gelery6.jpg" height="150px" Width="290px"/>
</td>
<td>
 <asp:Image ID="imgGelery11" runat="server"  ImageUrl="photos/Gelery11.jpeg" height="150px" Width="290px" />
</td>
</tr>
<tr>
<td>
 <asp:Image ID="imgGelery7" runat="server"  ImageUrl="photos/Gelery7.jpeg" height="150px" Width="290px"/>
</td>
<td>
 <asp:Image ID="imgGelery8" runat="server"  ImageUrl="photos/Gelery8.jpg" height="150px" Width="290px"/>
</td>
<td>
 <asp:Image ID="imgGelery9" runat="server"  ImageUrl="photos/Gelery9.jpeg" height="150px" Width="290px"/>
</td>
<td>
 <asp:Image ID="imgGelery12" runat="server"  ImageUrl="photos/Gelery12.jpeg" height="150px" Width="290px" />
</td>
</tr>

</table>
</asp:Content>

