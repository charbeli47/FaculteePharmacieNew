<%@ Page Title="" Language="C#" MasterPageFile="~/en/en.master" AutoEventWireup="true" CodeBehind="activities-details.aspx.cs" Inherits="FacultyOfPharmacy.en.activities_details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <div class="container">
					<h2 class="marTop4"><%=result.entitle %></h2>
        <div class="row" style="margin-left:0px">
    <%if(!string.IsNullOrEmpty(result.photo)){ %>
    <img src="../Media/<%=result.photo %>" />
    <%} %>
    <p><%=result.entext %></p>
    </div></div>
</asp:Content>
