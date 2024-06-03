<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.master" AutoEventWireup="true" CodeFile="Facilities.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphMainMaster" Runat="Server">
<table border="2">
<tr>
<td align="center" colspan="3" style="font-family: 'Arial Black'; font-size: 25px">
<b>Facilities</b>
</td></tr>
<tr>
<td align="center" style="font-size: 19px"  bgcolor="White"><b>Pharmacy</b></td>
<td align="center" style="font-size: 19px"  bgcolor="White"><b>Ambulance Service</b></td>
<td align="center" style="font-size: 19x"  bgcolor="White"><b>Blood Bank</b></td>
</tr>
<tr>
<td><asp:Image ID="imgPharmacy" runat="server"  ImageUrl="photos/Pharmacy.jpeg" height="120px" Width="200px"/></td>
<td><asp:Image ID="imgAmbulace" runat="server"  ImageUrl="photos/Ambulance.jpeg" height="120px" Width="200px"/></td>
<td><asp:Image ID="imgBlood" runat="server"  ImageUrl="photos/BloodBank.jpeg" height="120px" Width="200px"/></td>
</tr>
<tr>
<td align="center" style="font-size: 19px" bgcolor="White" ><b>Cafateria</b></td> 
<td align="center" style="font-size: 19px" bgcolor="White" ><b>Dental Facility</b></td>
<td align="center" style="font-size: 19px" bgcolor="White" ><b>Emergency Services</b></td>
</tr>
<tr>
<td><asp:Image ID="Image1" runat="server"  ImageUrl="photos/cafateria.jpeg" height="120px" Width="200px"/></td>
<td><asp:Image ID="Image2" runat="server"  ImageUrl="photos/Dental.jpeg" height="120px" Width="200px"/></td>
<td><asp:Image ID="Image3" runat="server"  ImageUrl="photos/Emergrncy.jpeg" height="120px" Width="200px"/></td>
</tr>
<tr>
<td align="center" style="font-size: 19px" bgcolor="White" ><b>Laboratory Services</b></td>
<td align="center" style="font-size: 19px" bgcolor="White" ><b>Radiology /X-Ray Facility</b></td>
<td align="center" style="font-size: 19px" bgcolor="White" ><b>Minor OT /Dressing Room</b></td>
</tr>
<tr>
<td><asp:Image ID="Image4" runat="server"  ImageUrl="photos/Laboratory.jpeg" height="120px" Width="200px"/></td>
<td><asp:Image ID="Image5" runat="server"  ImageUrl="photos/Radiology.jpeg" height="120px" Width="200px"/></td>
<td><asp:Image ID="Image6" runat="server"  ImageUrl="photos/DressingRoom.jpeg" height="120px" Width="200px"/></td>
</tr>
</table>

</asp:Content>

