<%@ Page Title="" Language="C#" MasterPageFile="~/en/en.master" AutoEventWireup="true" CodeBehind="Organigram.aspx.cs" Inherits="FacultyOfPharmacy.en.Organigram" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <div class="container">
					<h2 class="marTop4">Organigrame</h2>
        <div class="row" style="margin-left:0px">
    <p>
        <asp:Literal ID="organigramTxt" runat="server" />
    </p>
    <center><asp:Image ID="organigramImage" runat="server" Width="99%"/></center>
            </div></div>
</asp:Content>
