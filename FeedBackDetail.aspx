<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="FeedBackDetail.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cpmAdminMaster" Runat="Server">
<table border="2" bgcolor="White">
<tr><td style="font-family: 'Arial Black'; font-size: 30px" align="center">FeedBack Detail</td></tr>
<tr><td>
<div style="border-style:none; width:500px; height:200px; overflow:scroll">
<asp:DataGrid runat="server" ID="dgvFeedBack" Font-Bold="True" 
        Font-Size="Large"  /></div>
</td></tr>
<tr><td  align="center">
    <asp:Button runat="server" ID="btnBack" Text="Back" 
        Font-Bold="true" onclick="btnBack_Click"/></td></tr>
</table>
</asp:Content>

