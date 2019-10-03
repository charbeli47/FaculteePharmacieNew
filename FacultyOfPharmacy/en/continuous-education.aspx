<%@ Page Title="" Language="C#" MasterPageFile="~/en/en.master" AutoEventWireup="true" CodeBehind="continuous-education.aspx.cs" Inherits="FacultyOfPharmacy.en.continuous_education" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    
    <div class="container">
					<h2 class="marTop4">Continuous Education</h2>
					<div class="row" style="margin-left:0px">

						
                            <%foreach(var row in result){ %>
                        <div class="grid_3">
							<div class="wrapper marTop9">
								<h3><a href="continuous-education-details.aspx?educationId=<%=row.id %>" class="link2" style="color:black"><%=row.enname %></a></h3>
								<p><%=row.endescription.Length>228?row.endescription.Substring(0,228):row.endescription%></p>
								<p class="txt7"><a href="continuous-education-details.aspx?educationId=<%=row.id %>">More</a></p>
							</div></div>
                            <%} %>


					</div>

				</div>
</asp:Content>
