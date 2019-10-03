<%@ Page Title="" Language="C#" MasterPageFile="~/en/en.master" AutoEventWireup="true" CodeBehind="academics.aspx.cs" Inherits="FacultyOfPharmacy.en.academics" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    
    <div class="container">
					<h2 class="marTop4"><%=Request["category"] %></h2>
					<div class="row" style="margin-left:0px">
                        <asp:Literal ID="council" runat="server" />
						
                            <%foreach(var row in result){ %>
                        <div class="grid_3">
							<div class="wrapper marTop9">
								<h3><a href="academics-details.aspx?academicsId=<%=row.id %>" class="link2" style="color:black"><%=row.enname %></a></h3>
                                 <%if (Request["category"] == "Profs")
                                    { %><img src="../Media/<%=row.icon %>" style="height:150px;margin-top:5px"/><%}%>
								<p class="txt7"><a href="academics-details.aspx?academicsId=<%=row.id %>">More</a></p>
							</div>
                            </div>
                            <%} %>


					</div>

				</div>
</asp:Content>
