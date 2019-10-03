<%@ Page Title="" Language="C#" MasterPageFile="~/fr/fr.master" AutoEventWireup="true" CodeBehind="events-details.aspx.cs" Inherits="FacultyOfPharmacy.fr.events_details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <div class="container">
					<h2 class="marTop4"><%=result.frtitle %></h2>
    <div class="row" style="margin-left:0px">
    <%--<%if(!string.IsNullOrEmpty(result.photo)){ %>
    <img src="../Media/<%=result.photo %>" />
    <%} %>--%>
    <p>Debut Date: <%=result.date_start.Value.ToString("dd/MM/yyyy hh:mm:ss tt") %> <br /> Fin Date: <%=result.date_end.Value.ToString("dd/MM/yyyy hh:mm:ss tt") %></p>
    <p><%=result.frtext %></p>
    </div></div>
</asp:Content>
