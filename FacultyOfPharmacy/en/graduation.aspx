<%@ Page Title="" Language="C#" MasterPageFile="~/en/en.master" AutoEventWireup="true" CodeBehind="graduation.aspx.cs" Inherits="FacultyOfPharmacy.en.graduation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <div class="container">
					<h2 class="marTop4">Registration</h2>
        <div class="row" style="margin-left:0px">
    <%foreach(var category in categories){
          var rows = dc.CMSGetGraduation().Where(x => x.categoryId == category.id).ToList();
          %>
    <div class="container">
					<h2 class="marTop4" style="color:#c8474f;font-size:25px"><%=category.enname %></h2>
					<div class="row">

						
                            <%foreach(var row in rows){ %>
                        <div class="grid_3">
							<div class="wrapper marTop9">
								<h3><a href="graduation-details.aspx?gradId=<%=row.id %>" class="link2" style="color:#000000"><%=row.enname %></a></h3>
								<p style="max-height:125px;height:125px"><%=row.ensmalltext %></p>
								<p class="txt7"><a href="graduation-details.aspx?gradId=<%=row.id %>">More</a></p>
							</div>
                            </div>
                            <%} %>


					</div>

				</div>
    <%} %>
        </div></div>
</asp:Content>
