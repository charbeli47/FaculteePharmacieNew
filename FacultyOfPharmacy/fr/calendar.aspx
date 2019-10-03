<%@ Page Title="" Language="C#" MasterPageFile="~/fr/fr.master" AutoEventWireup="true" CodeBehind="calendar.aspx.cs" Inherits="FacultyOfPharmacy.fr.calendar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    
    <div class="container">
					<h2 class="marTop4">Horaire</h2>
					<div class="row" style="margin-left:0px">

						
                            <%foreach(var row in result){ %>
                        <div class="grid_3">
							<div class="wrapper marTop9">
								<h3><a href="calendar-details.aspx?calendarId=<%=row.id %>" class="link2" style="color:black"><%=row.frtitle %></a></h3>
								<p class="txt7"><a href="../Media/<%=row.thumb %>" target="_blank">Plus d'info</a></p>
							</div></div>
                            <%} %>


					</div>

				</div>
</asp:Content>
