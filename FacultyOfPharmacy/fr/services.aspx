<%@ Page Title="" Language="C#" MasterPageFile="~/fr/fr.master" AutoEventWireup="true" CodeBehind="services.aspx.cs" Inherits="FacultyOfPharmacy.fr.services" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    
    <div class="container">
					<h2 class="marTop4">Services</h2>
					<div class="row" style="margin-left:0px">

						
                            <%foreach(var row in result){ %>
                        <div class="grid_3">
							<div class="wrapper marTop9">
								<h3><a href="services-details.aspx?serviceId=<%=row.id %>" class="link2"><%=row.frtitle %></a></h3>
								<%if(!string.IsNullOrEmpty(row.photo)){ %>
    <img src="../Media/<%=row.photo %>" style="height:150px"/>
    <%} %>
    <p><%=row.frtext %></p>
							</div></div>
                            <%} %>


					</div>

				</div>
</asp:Content>
