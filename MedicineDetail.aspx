<%@ Page Title="" Language="C#" MasterPageFile="~/ClientMaster.master" AutoEventWireup="true" CodeFile="MedicineDetail.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphClientMaster" Runat="Server">

<table border="2" bgcolor="White">
<tr><td style="font-family: 'Arial Black'; font-size: 30px" align="center" colspan="3">Medicine Details</td></tr>

<tr><td colspan="3">
<div style="border-style:none; width:500px; height:200px; overflow:scroll">
<asp:DataGrid runat="server" ID="dgvMedicineDetail" 
        Font-Size="Large"  /></div>
</td></tr>
<tr><td  align="center" colspan="3"><asp:Button runat="server" ID="btnBack" Text="Back" 
        Font-Bold="true" onclick="btnBack_Click"/></td></tr>
</table>
</asp:Content>

