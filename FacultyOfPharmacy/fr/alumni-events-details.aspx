<%@ Page Title="" Language="C#" MasterPageFile="~/fr/fr.master" AutoEventWireup="true" CodeBehind="alumni-events-details.aspx.cs" Inherits="FacultyOfPharmacy.fr.alumni_events_details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <div class="container">
					<h2 class="marTop4"><%=result.frtitle %></h2>
    <div class="row" style="margin-left:0px">
    <%if(!string.IsNullOrEmpty(result.photo)){ %>
    <img src="../Media/<%=result.photo %>" />
    <%} %>
    <p>Start date: <%=result.date_start %> / End date: <%=result.date_end %></p>
    <p><%=result.frtext %></p>
    </div></div>
</asp:Content>
