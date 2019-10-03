<%@ Page Title="" Language="C#" MasterPageFile="~/fr/fr.master" AutoEventWireup="true" CodeBehind="news-details.aspx.cs" Inherits="FacultyOfPharmacy.fr.news_details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <div class="container">
					<h2 class="marTop4"><%=result.frtitle %></h2>
    <div class="row" style="margin-left:0px">
    <p>Date ajouté: <%=result.date_in %></p>
    <p><%=result.frtext %></p>
        <%if (!String.IsNullOrEmpty(result.pdf)){ %><a href="../Media/<%=result.pdf %>">Télécharger PDF</a><%} %>
    </div></div>
</asp:Content>
