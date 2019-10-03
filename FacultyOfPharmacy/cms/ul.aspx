<%@ Page Title="" Language="C#" MasterPageFile="~/cms/cms.Master" AutoEventWireup="true" CodeBehind="ul.aspx.cs" Inherits="FacultyOfPharmacy.cms.ul" %>
<asp:Content ID="Content1" ContentPlaceHolderID="main" runat="server">
<form runat="server">
<h2>Welcome note</h2>
      <table style="width:700px">
      <tr><td>Arabic:</td><td><asp:TextBox ID="arWelcomeNote" TextMode="MultiLine" runat="server" style="width:100%;height:100px"></asp:TextBox>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="arWelcomeNote" runat="server" Text="this field is required" ForeColor="Red"></asp:RequiredFieldValidator></td></tr>
      <tr><td>French:</td><td><asp:TextBox ID="frWelcomeNote" TextMode="MultiLine" runat="server" style="width:100%;height:100px"></asp:TextBox>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="frWelcomeNote" runat="server" Text="this field is required" ForeColor="Red"></asp:RequiredFieldValidator></td></tr>
      <tr><td>English:</td><td><asp:TextBox ID="enWelcomeNote" TextMode="MultiLine" runat="server" style="width:100%;height:100px"></asp:TextBox>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="enWelcomeNote" runat="server" Text="this field is required" ForeColor="Red"></asp:RequiredFieldValidator></td></tr></table>
      <h2>Director word</h2>
      <table style="width:700px">
      <tr><td>Arabic:</td><td><asp:TextBox ID="arDirectorWord" TextMode="MultiLine" runat="server" style="width:100%;height:100px"></asp:TextBox>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="arDirectorWord" runat="server" Text="this field is required" ForeColor="Red"></asp:RequiredFieldValidator></td></tr>
      <tr><td>French:</td><td><asp:TextBox ID="frDirectorWord" TextMode="MultiLine" runat="server" style="width:100%;height:100px"></asp:TextBox>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ControlToValidate="frDirectorWord" runat="server" Text="this field is required" ForeColor="Red"></asp:RequiredFieldValidator></td></tr>
      <tr><td>English:</td><td><asp:TextBox ID="enDirectorWord" TextMode="MultiLine" runat="server" style="width:100%;height:100px"></asp:TextBox>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator6" ControlToValidate="enDirectorWord" runat="server" Text="this field is required" ForeColor="Red"></asp:RequiredFieldValidator></td></tr>
      <tr><td></td><td align="left"><div style="width:76.5%;text-align:right">
          <asp:Button ID="SaveULBtn" runat="server" Text="Save" 
              onclick="SaveULBtn_Click"/></div></td></tr>
      </table>
      </form>
</asp:Content>
