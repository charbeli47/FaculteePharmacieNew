<%@ Page Title="" Language="C#" MasterPageFile="~/en/en.master" AutoEventWireup="true" CodeBehind="activities.aspx.cs" Inherits="FacultyOfPharmacy.en.activities" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    
    <div class="container">
					<h2 class="marTop4">Activities</h2>
					<div class="row" style="margin-left:0px">

						
                            <%foreach(var row in result){ %>
                        <div class="grid_3">
							<div class="wrapper marTop9">
								<h3><a href="activities-details.aspx?activityId=<%=row.id %>" class="link2"><%=row.entitle %></a></h3>
								<p><%=row.entext.Length>228?row.entext.Substring(0,228):row.entext%></p>
								<p class="txt7"><a href="activities-details.aspx?activityId=<%=row.id %>">More</a></p>
							</div></div>
                            <%} %>


					</div>

				</div>
</asp:Content>
