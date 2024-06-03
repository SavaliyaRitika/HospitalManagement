<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.master" AutoEventWireup="true" CodeFile="Rules.aspx.cs" Inherits="Default2" %>

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
<table border="2" >
<tr>
<td colspan="2" align="center" style="font-family: 'Arial Black'; font-size: 30px"><b>Rules&Regulation</b></td>
</tr>
<tr>
<td style="font-family: 'Arial Black'; font-size: 20px"><b>SrNo</b></td>
<td style="font-family: 'Arial Black'; font-size: 20px" align="center"><b>Rules</b></td>
</tr>
<tr style="font-size: 20px">
<td><b>1.</b></td>
<td><b>Know the hospital rules.</b></td>
</tr>
<tr style="font-size: 20px">
<td><b>2.</b></td>
<td><b>Take Permission before you visit your patient.</b></td>
</tr>
<tr style="font-size: 20px">
<td><b>3.</b></td>
<td><b>Be clean.</b></td>
</tr>
<tr style="font-size: 20px">
<td><b>4.</b></td>
<td><b>Do not smoke anywhere in the hospital.</b></td>
</tr>
<tr style="font-size: 20px">
<td><b>5.</b></td>
<td><b>Give respect to the medical professionals.</b></td>
</tr>
<tr style="font-size: 20px">
<td><b>6.</b></td>
<td><b>Do not damage or remove hospital property or the<br /> property of other patients.</b></td>
</tr>
<tr style="font-size: 20px">
<td><b>7.</b></td>
<td><b>Stay for a short time as prescribed in the notice.</b></td>
</tr>
<tr style="font-size: 20px">
<td><b>8.</b></td>
<td><b>Observe and follow the signs, notices, and <br /> precautions in and around the Hospital.</b></td>
</tr>
<tr style="font-size: 20px">
<td><b>9.</b></td>
<td><b>Don't help the patient get out of bed or give <br /> food or drink or any kind of seductive without<br /> an approval from treating doctors..</b></td>
</tr>
<tr style="font-size: 20px">
<td><b>10.</b></td>
<td><b>Don't park your vehicle at non designated areas.</b></td>
</tr>
</table>


</asp:Content>

