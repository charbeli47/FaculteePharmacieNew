<%@ Page Title="" Language="C#" MasterPageFile="~/fr/fr.master" AutoEventWireup="true" CodeBehind="HROrganigram.aspx.cs" Inherits="FacultyOfPharmacy.fr.HROrganigram" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <div class="container">
					<h2 class="marTop4">Organigramme</h2>
        <div class="row" style="margin-left:0px">
    <p>
        <asp:Literal ID="organigramTxt" runat="server" />
    </p>
    <center><asp:Image ID="organigramImage" runat="server"/></center>
            </div></div>
</asp:Content>
