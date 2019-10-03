<%@ Page Title="" Language="C#" MasterPageFile="~/fr/fr.master" AutoEventWireup="true" CodeBehind="alumni-events.aspx.cs" Inherits="FacultyOfPharmacy.fr.alumni_events" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    
    <div class="container">
					<h2 class="marTop4">Événements Alumni</h2>
					<div class="row" style="margin-left:0px">

						
                            <%foreach(var row in result){ %>
                        <div class="grid_3">
							<div class="wrapper marTop9">
								<h3><a href="alumni-events-details.aspx?eventId=<%=row.id %>" class="link2"><%=row.frtitle %></a></h3>
                                <p>Start date: <%=row.date_start %> / End date: <%=row.date_end %></p>
								<p><%=row.frtext.Length>228?row.frtext.Substring(0,228):row.frtext%></p>
								<p class="txt7"><a href="alumni-events-details.aspx?eventId=<%=row.id %>">Plus d'info</a></p>
							</div></div>
                            <%} %>


					</div>

				</div>
</asp:Content>
