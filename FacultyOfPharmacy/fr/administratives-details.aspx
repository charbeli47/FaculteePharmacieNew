<%@ Page Title="" Language="C#" MasterPageFile="~/fr/fr.master" AutoEventWireup="true" CodeBehind="administratives-details.aspx.cs" Inherits="FacultyOfPharmacy.fr.administratives_details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <div class="container">
					<h2 class="marTop4"><%=result.frname %></h2>
        <div class="row" style="margin-left:0px">

						
    <%if(!string.IsNullOrEmpty(result.icon)){ %>
    <img src="../Media/<%=result.icon %>" />
    <%} %>
    <p><%=result.frdescription %></p>
    </div></div>
</asp:Content>
