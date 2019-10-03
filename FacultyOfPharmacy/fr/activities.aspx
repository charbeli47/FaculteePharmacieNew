<%@ Page Title="" Language="C#" MasterPageFile="~/fr/fr.master" AutoEventWireup="true" CodeBehind="activities.aspx.cs" Inherits="FacultyOfPharmacy.fr.activities" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    
    <div class="container">
					<h2 class="marTop4">Activités</h2>
					<div class="row" style="margin-left:0px">

						
                            <%foreach(var row in result){ %>
                        <div class="grid_3">
							<div class="wrapper marTop9">
								<h3><a href="activities-details.aspx?activityId=<%=row.id %>" class="link2"><%=row.frtitle %></a></h3>
								<p><%=row.frtext.Length>228?row.entext.Substring(0,228):row.frtext%></p>
								<p class="txt7"><a href="activities-details.aspx?activityId=<%=row.id %>">Plus d'info</a></p>
							</div></div>
                            <%} %>


					</div>

				</div>
</asp:Content>
