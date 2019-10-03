<%@ Page Title="" Language="C#" MasterPageFile="~/en/en.master" AutoEventWireup="true" CodeBehind="events-details.aspx.cs" Inherits="FacultyOfPharmacy.en.events_details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <div class="container">
					<h2 class="marTop4"><%=result.entitle %></h2>
    <div class="row" style="margin-left:0px">
    <%--<%if(!string.IsNullOrEmpty(result.photo)){ %>
    <img src="../Media/<%=result.photo %>" />
    <%} %>--%>
    <p>Start date: <%=result.date_start %> / End date: <%=result.date_end %></p>
    <p><%=result.entext %></p>
    </div></div>
</asp:Content>
