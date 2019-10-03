<%@ Page Title="" Language="C#" MasterPageFile="~/en/en.master" AutoEventWireup="true" CodeBehind="events.aspx.cs" Inherits="FacultyOfPharmacy.en.events" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    
    <div class="container">
					<h2 class="marTop4">Events</h2>
					<div class="row" style="margin-left:0px">

						
                            <%foreach(var row in result){ %>
                        <div class="grid_3">
							<div class="wrapper marTop9">
								<h3><a href="events-details.aspx?id=<%=row.id %>" class="link2"><%=row.entitle %></a></h3>
                                <p>Start date: <%=row.date_start %> / End date: <%=row.date_end %></p>
								<p><%=row.entext.Length>228?row.entext.Substring(0,228):row.entext%></p>
								<p class="txt7"><a href="events-details.aspx?id=<%=row.id %>">More</a></p>
							</div></div>
                            <%} %>


					</div>

				</div>
</asp:Content>
