 <%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="HomeAdmin.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cpmAdminMaster" Runat="Server">


<table><tr><td style="width:20px" ></td>
<td style="font-size: 40px; font-family: Georgia; color: #008080;" >
<asp:Label ID="lblWelcome" runat="server" Text="WelCome"    
        Font-Bold="True" Font-Italic="True" /></td></tr></table>

 <table><tr><td style="width:120px"></td>
<td style="font-size: 40px; font-family: Georgia; color: #008080;"> <asp:Label ID="lblTo" runat="server" Text="To" 
        Font-Bold="True" Font-Italic="True"/></td></tr></table>   

<table><tr><td style="width:140px"></td>
<td style="font-size: 40px; font-family: Georgia; color: #008080;"><asp:Label ID="lblPanel" runat="server" Text="Admin Panel" Font-Size="Larger"  
        Font-Bold="True" Font-Italic="True"/></td></tr></table>   


</asp:Content>

