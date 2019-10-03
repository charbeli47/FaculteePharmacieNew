<%@ Page Title="" Language="C#" MasterPageFile="~/fr/fr.master" AutoEventWireup="true" CodeBehind="history.aspx.cs" Inherits="FacultyOfPharmacy.fr.history" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <div class="container">
					<h2 class="marTop4">Historique</h2>
        <div class="row" style="margin-left:0px;margin-top:5px">
    <asp:Image ID="historyImg" runat="server" style="width:100%"/>
    <p>
        <asp:Literal ID="historyTxt" runat="server" />
    </p>
            </div></div>
</asp:Content>
