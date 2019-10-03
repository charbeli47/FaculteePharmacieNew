<%@ Page Title="" Language="C#" MasterPageFile="~/en/en.master" AutoEventWireup="true" CodeBehind="administratives-details.aspx.cs" Inherits="FacultyOfPharmacy.en.administratives_details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <div class="container">
					<h2 class="marTop4"><%=result.enname %></h2>
        <div class="row" style="margin-left:0px">

						
    <%if(!string.IsNullOrEmpty(result.icon)){ %>
    <img src="../Media/<%=result.icon %>" />
    <%} %>
    <p><%=result.endescription %></p>
    </div></div>
</asp:Content>
