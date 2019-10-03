<%@ Page Title="" Language="C#" MasterPageFile="~/fr/fr.master" AutoEventWireup="true" CodeBehind="news.aspx.cs" Inherits="FacultyOfPharmacy.fr.news" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    
    <div class="container">
					<h2 class="marTop4">Nouvelles</h2>
					<div class="row" style="margin-left:0px">

						
                            <%foreach(var row in result){ %>
                        <div class="grid_3">
							<div class="wrapper marTop9">
								<h3><a href="news-details.aspx?id=<%=row.id %>" class="link2"><%=row.frtitle %></a></h3>
                                <p>Date ajouté: <%=row.date_in %></p>
								<p class="txt7"><a href="news-details.aspx?id=<%=row.id %>">Plus d'info</a></p>
							</div></div>
                            <%} %>


					</div>

				</div>
</asp:Content>
