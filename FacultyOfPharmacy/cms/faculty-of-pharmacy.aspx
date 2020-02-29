<%@ Page Title="" Language="C#" MasterPageFile="~/cms/cms.Master" AutoEventWireup="true" CodeBehind="faculty-of-pharmacy.aspx.cs" Inherits="FacultyOfPharmacy.cms.faculty_of_pharmacy" %>
<asp:Content ID="Content1" ContentPlaceHolderID="main" runat="server">
<form runat="server">
      <h2>Dean word</h2>
      <table style="width:700px">
      <tr><td>Arabic:</td><td><asp:TextBox ID="arDeanWord" TextMode="MultiLine" runat="server" style="width:100%;height:100px"></asp:TextBox>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator6" ControlToValidate="arDeanWord" runat="server" Text="this field is required" ForeColor="Red"></asp:RequiredFieldValidator></td></tr>
      <tr><td>French:</td><td><asp:TextBox ID="frDeanWord" TextMode="MultiLine" runat="server" style="width:100%;height:100px"></asp:TextBox>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator7" ControlToValidate="frDeanword" runat="server" Text="this field is required" ForeColor="Red"></asp:RequiredFieldValidator></td></tr>
      <tr><td>English:</td><td><asp:TextBox ID="enDeanWord" TextMode="MultiLine" runat="server" style="width:100%;height:100px"></asp:TextBox>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator8" ControlToValidate="enDeanWord" runat="server" Text="this field is required" ForeColor="Red"></asp:RequiredFieldValidator></td></tr>
      <tr><td></td><td align="left"><div style="width:76.5%;text-align:right">
          <asp:Button ID="SaveFOPBtn" runat="server" Text="Save" 
              onclick="SaveFOPBtn_Click"/></div></td></tr>
      </table>
      </form>
</asp:Content>
