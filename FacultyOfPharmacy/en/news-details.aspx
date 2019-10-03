<%@ Page Title="" Language="C#" MasterPageFile="~/en/en.master" AutoEventWireup="true" CodeBehind="news-details.aspx.cs" Inherits="FacultyOfPharmacy.en.news_details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <div class="container">
					<h2 class="marTop4"><%=result.entitle %></h2>
    <div class="row" style="margin-left:0px">
    <p>Date added: <%=result.date_in %></p>
    <p><%=result.entext %></p>
        <%if (!String.IsNullOrEmpty(result.pdf)){ %><a href="../Media/<%=result.pdf %>">Download PDF</a><%} %>
    </div></div>
</asp:Content>
