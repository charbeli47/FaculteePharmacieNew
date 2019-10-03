<%@ Page Title="" Language="C#" MasterPageFile="~/fr/fr.master" AutoEventWireup="true" CodeBehind="continuous-education.aspx.cs" Inherits="FacultyOfPharmacy.fr.continuous_education" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    
    <div class="container">
					<h2 class="marTop4">Formation Continue</h2>
					<div class="row" style="margin-left:0px">

						
                            <%foreach(var row in result){ %>
                        <div class="grid_3">
							<div class="wrapper marTop9">
								<h3><a href="continuous-education-details.aspx?educationId=<%=row.id %>" class="link2" style="color:black"><%=row.frname %></a></h3>
								<p><%=row.frdescription.Length>228?row.frdescription.Substring(0,228):row.frdescription%></p>
								<p class="txt7"><a href="continuous-education-details.aspx?educationId=<%=row.id %>">Plus d'info</a></p>
							</div></div>
                            <%} %>


					</div>

				</div>
</asp:Content>
