<%@ Page Title="" Language="C#" MasterPageFile="~/cms/cms.Master" AutoEventWireup="true" CodeBehind="settings.aspx.cs" Inherits="FacultyOfPharmacy.cms.settings" %>
<asp:Content ID="Content1" ContentPlaceHolderID="main" runat="server">
<script type="text/javascript">
    $(function () {
        $(".box .h_title").not(this).next("ul").hide("normal");
        $(".box .h_title").not(this).next("#home").show("normal");
        $(".box").children(".h_title").click(function () { $(this).next("ul").slideToggle(); });
    });
</script>
<form runat="server">
<table>
<tr><td>Website Keywords:</td><td><asp:TextBox ID="Keywords" Columns="50" Rows="20" TextMode="MultiLine" runat="server" /></td></tr>
<tr><td valign="top">Website Description:</td><td><asp:TextBox ID="Description" Columns="50" Rows="20" TextMode="MultiLine" runat="server" /></td></tr>
<tr><td valign="top">Smtp Server:</td><td><asp:TextBox ID="smtpServer" runat="server" /></td></tr>
<tr><td valign="top">smtpPort:</td><td><asp:TextBox ID="smtpPort" runat="server" /></td></tr>
<tr><td valign="top">User credential:</td><td><asp:TextBox ID="emailUser" runat="server" /></td></tr>
<tr><td valign="top">Password credential:</td><td><asp:TextBox ID="emailPassword" runat="server" /></td></tr>
<tr><td valign="top">Recipient email:</td><td><asp:TextBox ID="recipient" runat="server" /></td></tr>
<tr><td valign="top">Sender email:</td><td><asp:TextBox ID="senders" runat="server" /></td></tr>
<tr><td valign="top">Website Link:</td><td><asp:TextBox ID="WebsiteLink" runat="server" /></td></tr>
<tr><td colspan="2"><h1>Dean Word</h1></td></tr>
    <tr><td valign="top">English:</td><td><asp:TextBox ID="enDeanWord" Columns="50" Rows="20" TextMode="MultiLine" runat="server" /></td></tr>
    <tr><td valign="top">French:</td><td><asp:TextBox ID="frDeanWord" Columns="50" Rows="20" TextMode="MultiLine" runat="server" /></td></tr>
    <tr><td valign="top">Arabic:</td><td><asp:TextBox ID="arDeanWord" Columns="50" Rows="20" TextMode="MultiLine" runat="server" /></td></tr>
    <tr><td valign="top">Thumbnail:</td><td><asp:FileUpload ID="thumbDeanWord" runat="server" /><br /><asp:Image ID="DeanImg" runat="server" /></td></tr>
<tr><td colspan="2"><h1>History</h1></td></tr>
    <tr><td valign="top">English:</td><td><asp:TextBox Columns="50" Rows="20" TextMode="MultiLine" ID="enHistory" runat="server" /></td></tr>
    <tr><td valign="top">French:</td><td><asp:TextBox Columns="50" Rows="20" TextMode="MultiLine" ID="frHistory" runat="server" /></td></tr>
    <tr><td valign="top">Arabic:</td><td><asp:TextBox Columns="50" Rows="20" TextMode="MultiLine" ID="arHistory" runat="server" /></td></tr>
    <tr><td valign="top">Thumbnail:</td><td><asp:FileUpload ID="thumbHistory" runat="server" /><br /><asp:Image ID="HistoryImg" runat="server" /></td></tr>
    <tr><td colspan="2"><h1>Organigrame</h1></td></tr>
    <tr><td valign="top">English:</td><td><asp:TextBox ID="enOrganigrame" Columns="50" Rows="20" TextMode="MultiLine" runat="server" /></td></tr>
    <tr><td valign="top">French:</td><td><asp:TextBox ID="frOrganigrame" Columns="50" Rows="20" TextMode="MultiLine" runat="server" /></td></tr>
    <tr><td valign="top">Arabic:</td><td><asp:TextBox ID="arOrganigrame" Columns="50" Rows="20" TextMode="MultiLine" runat="server" /></td></tr>
    <tr><td valign="top">English Thumbnail:</td><td><asp:FileUpload ID="thumbOrganigrame" runat="server" /><br /><asp:Image ID="OrganigrameImg" runat="server" /></td></tr>
    <tr><td valign="top">French Thumbnail:</td><td><asp:FileUpload ID="frthumbOrganigrame" runat="server" /><br /><asp:Image ID="frOrganigrameImg" runat="server" /></td></tr>
    <tr><td colspan="2"><h1>Mission</h1></td></tr>
    <tr><td valign="top">English:</td><td><asp:TextBox ID="enMission" Columns="50" Rows="20" TextMode="MultiLine" runat="server" /></td></tr>
    <tr><td valign="top">French:</td><td><asp:TextBox ID="frMission" Columns="50" Rows="20" TextMode="MultiLine" runat="server" /></td></tr>
    <tr><td valign="top">Arabic:</td><td><asp:TextBox ID="arMission" Columns="50" Rows="20" TextMode="MultiLine" runat="server" /></td></tr>
    <tr><td colspan="2"><h1>Affair Estudiantine</h1></td></tr>
    <tr><td valign="top">English:</td><td><asp:TextBox ID="enAffairEstudiantine" Columns="50" Rows="20" TextMode="MultiLine" runat="server" /></td></tr>
    <tr><td valign="top">French:</td><td><asp:TextBox ID="frAffairEstudiantine" Columns="50" Rows="20" TextMode="MultiLine" runat="server" /></td></tr>
    <tr><td valign="top">Arabic:</td><td><asp:TextBox ID="arAffairEstudiantine" Columns="50" Rows="20" TextMode="MultiLine" runat="server" /></td></tr>
    <tr><td colspan="2"><h1>Orientation</h1></td></tr>
    <tr><td valign="top">English:</td><td><asp:TextBox ID="enOrientation" Columns="50" Rows="20" TextMode="MultiLine" runat="server" /></td></tr>
    <tr><td valign="top">French:</td><td><asp:TextBox ID="frOrientation" Columns="50" Rows="20" TextMode="MultiLine" runat="server" /></td></tr>
    <tr><td valign="top">Arabic:</td><td><asp:TextBox ID="arOrientation" Columns="50" Rows="20" TextMode="MultiLine" runat="server" /></td></tr>
    <tr><td colspan="2"><h1>HR Organigramme</h1></td></tr>
    <tr><td valign="top">English:</td><td><asp:TextBox ID="enHrOrganigrame" Columns="50" Rows="20" TextMode="MultiLine" runat="server" /></td></tr>
    <tr><td valign="top">French:</td><td><asp:TextBox ID="frHROrganigrame" Columns="50" Rows="20" TextMode="MultiLine" runat="server" /></td></tr>
    <tr><td valign="top">Arabic:</td><td><asp:TextBox ID="arHROrganigrame" Columns="50" Rows="20" TextMode="MultiLine" runat="server" /></td></tr>
    <tr><td valign="top">Thumbnail:</td><td><asp:FileUpload ID="thumbHROrganigrame" runat="server" /><br /><asp:Image ID="HROrganigrameImg" runat="server" /></td></tr>
    <tr><td colspan="2"><h1>Conseil</h1></td></tr>
    <tr><td valign="top">English:</td><td><asp:TextBox ID="enConseil" Columns="50" Rows="20" TextMode="MultiLine" runat="server" /></td></tr>
    <tr><td valign="top">French:</td><td><asp:TextBox ID="frConseil" Columns="50" Rows="20" TextMode="MultiLine" runat="server" /></td></tr>
    <tr><td valign="top">Arabic:</td><td><asp:TextBox ID="arConseil" Columns="50" Rows="20" TextMode="MultiLine" runat="server" /></td></tr>
    <tr><td colspan="2"><h1>Employment</h1></td></tr>
    <tr><td valign="top">English:</td><td><asp:TextBox ID="enEmployment" Columns="50" Rows="20" TextMode="MultiLine" runat="server" /></td></tr>
    <tr><td valign="top">French:</td><td><asp:TextBox ID="frEmployment" Columns="50" Rows="20" TextMode="MultiLine" runat="server" /></td></tr>
    <tr><td valign="top">Arabic:</td><td><asp:TextBox ID="arEmployment" Columns="50" Rows="20" TextMode="MultiLine" runat="server" /></td></tr>
    <tr><td colspan="2"><h1>Alumni(Pharmaclub)</h1></td></tr>
    <tr><td valign="top">English:</td><td><asp:TextBox ID="enAlumni" Columns="50" Rows="20" TextMode="MultiLine" runat="server" /></td></tr>
    <tr><td valign="top">French:</td><td><asp:TextBox ID="frAlumni" Columns="50" Rows="20" TextMode="MultiLine" runat="server" /></td></tr>
    <tr><td valign="top">Arabic:</td><td><asp:TextBox ID="arAlumni" Columns="50" Rows="20" TextMode="MultiLine" runat="server" /></td></tr>
<tr><td colspan="2"><asp:Button ID="saveSEO" runat="server" Text="Save" 
        onclick="saveSEO_Click" /></td></tr>
</table>
</form>
</asp:Content>
