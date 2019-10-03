<%@ Page Title="" Language="C#" MasterPageFile="~/cms/cms.Master" AutoEventWireup="true" CodeBehind="mission.aspx.cs" Inherits="FacultyOfPharmacy.cms.mission" %>
<asp:Content ID="Content1" ContentPlaceHolderID="main" runat="server">
<form id="Form1" runat="server">
      <h2>Mission</h2>
      <table style="width:700px">
      <tr><td>Arabic:</td><td><asp:TextBox ID="ar" TextMode="MultiLine" runat="server" style="width:100%;height:100px"></asp:TextBox>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator6" ControlToValidate="ar" runat="server" Text="this field is required" ForeColor="Red"></asp:RequiredFieldValidator></td></tr>
      <tr><td>French:</td><td><asp:TextBox ID="fr" TextMode="MultiLine" runat="server" style="width:100%;height:100px"></asp:TextBox>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator7" ControlToValidate="fr" runat="server" Text="this field is required" ForeColor="Red"></asp:RequiredFieldValidator></td></tr>
      <tr><td>English:</td><td><asp:TextBox ID="en" TextMode="MultiLine" runat="server" style="width:100%;height:100px"></asp:TextBox>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator8" ControlToValidate="en" runat="server" Text="this field is required" ForeColor="Red"></asp:RequiredFieldValidator></td></tr>
      <tr><td></td><td align="left"><div style="width:76.5%;text-align:right">
          <asp:Button ID="SaveFOPBtn" runat="server" Text="Save" 
              onclick="SaveFOPBtn_Click"/></div></td></tr>
      </table>
      </form>
</asp:Content>
