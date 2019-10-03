<%@ Page Title="" Language="C#" MasterPageFile="~/en/en.master" AutoEventWireup="true" CodeBehind="dean-word.aspx.cs" Inherits="FacultyOfPharmacy.en.dean_word" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <div class="container">
					<h2 class="marTop4">Dean's word</h2>
        <div class="row" style="margin-left:0px">
    <figure style="width:180px;float:left;margin-right:20px;">
        <asp:Image ID="DeanImage" runat="server" Width="180" />
    </figure>
    <p style="left:20px">
    <asp:Literal ID="DeanWord" runat="server" />
        </p></div></div>
</asp:Content>
