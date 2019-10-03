<%@ Page Title="" Language="C#" MasterPageFile="~/en/en.master" AutoEventWireup="true" CodeBehind="calendar.aspx.cs" Inherits="FacultyOfPharmacy.en.calendar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    
    <div class="container">
					<h2 class="marTop4">Calendar</h2>
					<div class="row" style="margin-left:0px">

						
                            <%foreach(var row in result){ %>
                        <div class="grid_3">
							<div class="wrapper marTop9">
								<h3><a href="calendar-details.aspx?calendarId=<%=row.id %>" class="link2" style="color:black"><%=row.title %></a></h3>
								<p class="txt7"><a href="../Media/<%=row.thumb %>" target="_blank">More</a></p>
							</div></div>
                            <%} %>


					</div>

				</div>
</asp:Content>
