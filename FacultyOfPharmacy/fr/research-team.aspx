<%@ Page Title="" Language="C#" MasterPageFile="~/fr/fr.master" AutoEventWireup="true" CodeBehind="research-team.aspx.cs" Inherits="FacultyOfPharmacy.en.research_teams" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <div class="container">
					<h2 class="marTop4"><%=result.frtitle %></h2>
        <div class="row" style="margin-left:0px">
    <h3>Membres</h3>
    <p><%=result.frmembersText %></p>
    <h3>Publications</h3>
    <p><%=result.frpublicationsText %></p>
    </div></div>
</asp:Content>
