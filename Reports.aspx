<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="Reports.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cpmAdminMaster" Runat="Server">
<table>
<tr>
<td>
<asp:Button runat="server" ID="btnDoctor" Text="Doctor Report"  Font-Bold="True" 
        Font-Size="Large" onclick="btnDoctor_Click" />
</td>
<td style="width: 50px"></td>
<td>
<asp:Button runat="server" ID="btnMedicine" Text="Medicine Report"  
        Font-Bold="True" Font-Size="Large" onclick="btnMedicine_Click"/>
</td>
</tr>
<tr>
<td colspan="3" align="center">
<asp:Button runat="server" ID="btnPatient" Text="Patient Report"  Font-Bold="True" 
        Font-Size="Large" onclick="btnPatient_Click"/>
</td>
</tr>
<tr>
<td>
<asp:Button runat="server" ID="btnWard" Text="Ward Report"  Font-Bold="True" 
        Font-Size="Large" onclick="btnWard_Click" />
</td>
<td  style="width: 50px"></td>
<td>
<asp:Button runat="server" ID="btnDischarge" Text="Discharge Report"  
        Font-Bold="True" Font-Size="Large" onclick="btnDischarge_Click" />
</td>
</tr>
<tr><td style="height: 50px"></td></tr>
<tr><td colspan="3" align="center"><asp:Button runat="server" ID="btnBack" 
        Text="Back" onclick="btnBack_Click" /></td></tr>
</table>
</asp:Content>

