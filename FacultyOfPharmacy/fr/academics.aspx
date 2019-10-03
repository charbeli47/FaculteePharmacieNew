<%@ Page Title="" Language="C#" MasterPageFile="~/fr/fr.master" AutoEventWireup="true" CodeBehind="academics.aspx.cs" Inherits="FacultyOfPharmacy.fr.academics" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    
    <div class="container">
					<h2 class="marTop4"><%=Request["category"]=="Profs"?"Enseignants":"Conseil de la Faculté" %></h2>
					<div class="row" style="margin-left:0px">
                        <asp:Literal ID="council" runat="server" />
						
                            <%foreach(var row in result){ %>
                        <div class="grid_3">
							<div class="wrapper marTop9">
								<h3><a href="academics-details.aspx?academicsId=<%=row.id %>" class="link2" style="color:black"><%=row.frname %></a></h3>
                                <%if (Request["category"] == "Profs")
                                    { %><img src="../Media/<%=row.icon %>" style="height:150px;margin-top:5px"/><%}%>
								<p class="txt7"><a href="academics-details.aspx?academicsId=<%=row.id %>">Plus d'info</a></p>
							</div>
                            </div>
                            <%} %>


					</div>

				</div>
</asp:Content>
