<%@ Page Title="" Language="C#" MasterPageFile="~/fr/fr.master" AutoEventWireup="true" CodeBehind="calendar-details.aspx.cs" Inherits="FacultyOfPharmacy.fr.calendar_details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <div class="container">
					<h2 class="marTop4"><%=result.frtitle %></h2>
        <div class="row" style="margin-left:0px">
    <%if(!string.IsNullOrEmpty(result.thumb)){ %>
    <img src="../Media/<%=result.thumb %>" />
    <%} %>
    </div></div>
</asp:Content>
