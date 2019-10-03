<%@ Page Title="" Language="C#" MasterPageFile="~/fr/fr.master" AutoEventWireup="true" CodeBehind="graduation-details.aspx.cs" Inherits="FacultyOfPharmacy.fr.graduation_details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <div class="container">
					<h2 class="marTop4"><%=result.frname %></h2>
        <div class="row" style="margin-left:0px">
    <p><%=result.frtext %></p>
    <%if(files.Count>0) {%><br /><hr /><br />
    <h3>Formats</h3>
    <%for (int i = 0; i < files.Count;i++ )
      { %>
    <a href="../Media/<%=files[i].filename%>" target="_blank"><%=files[i].frtitle %></a><br />
    <%} }%>
            </div></div>
</asp:Content>
