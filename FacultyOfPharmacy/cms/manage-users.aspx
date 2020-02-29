<%@ Page Title="" Language="C#" MasterPageFile="~/cms/cms.Master" AutoEventWireup="true" CodeBehind="manage-users.aspx.cs" Inherits="FacultyOfPharmacy.cms.manage_users" %>
<asp:Content ID="Content1" ContentPlaceHolderID="main" runat="server">
<script type="text/javascript">
    $(function () {
        $(".box .h_title").not(this).next("ul").hide("normal");
        $(".box .h_title").not(this).next("#users").show("normal");
        $(".box").children(".h_title").click(function () { $(this).next("ul").slideToggle(); });
    });
</script>
</asp:Content>
