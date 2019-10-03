<%@ Page Title="" Language="C#" MasterPageFile="~/fr/fr.master" AutoEventWireup="true" CodeBehind="continuous-education-details.aspx.cs" Inherits="FacultyOfPharmacy.fr.continuous_education_details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <div class="container">
					<h2 class="marTop4"><%=result.frname %></h2>
        <div class="row" style="margin-left:0px">
    <%if(!string.IsNullOrEmpty(result.thumb)){ %>
    <img src="../Media/<%=result.thumb %>" />
    <%} %>
    <p><%=result.frdescription %></p>
    </div></div>
</asp:Content>
