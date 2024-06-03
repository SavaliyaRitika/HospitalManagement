<%@ Page Title="" Language="C#" MasterPageFile="~/ClientMaster.master" AutoEventWireup="true" CodeFile="HomeClient.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphClientMaster" Runat="Server">
<table><tr><td style="width:20px" ></td>
<td style="font-size: 40px; font-family: Georgia; color: #008080;" >
<asp:Label ID="lblWelcome" runat="server" Text="WelCome"    
        Font-Bold="True" Font-Italic="True" /></td></tr></table>

 <table><tr><td style="width:120px"></td>
<td style="font-size: 40px; font-family: Georgia; color: #008080;"> <asp:Label ID="lblTo" runat="server" Text="To" 
        Font-Bold="True" Font-Italic="True"/></td></tr></table>   

<table><tr><td style="width:140px"></td>
<td style="font-size: 40px; font-family: Georgia; color: #008080;"><asp:Label ID="lblPanel" runat="server" Text="Client Panel" Font-Size="Larger"  
        Font-Bold="True" Font-Italic="True"/></td></tr></table>   
</asp:Content>

