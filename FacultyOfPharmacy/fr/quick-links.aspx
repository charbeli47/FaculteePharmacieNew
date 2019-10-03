<%@ Page Title="Quick Links" Language="C#" MasterPageFile="~/fr/fr.master" AutoEventWireup="true" CodeBehind="quick-links.aspx.cs" Inherits="FacultyOfPharmacy.fr.quick_links" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <div class="container">
					<h2 class="marTop4">Liens Utiles</h2>
					<div class="row" style="margin-left:0px">
    <%foreach(var row in result){
          
          System.Net.WebClient x = new System.Net.WebClient();
          string pageSource = x.DownloadString(row.link);
          string title = Regex.Match(pageSource, @"\<title\b[^>]*\>\s*(?<Title>[\s\S]*?)\</title\>", RegexOptions.IgnoreCase).Groups["Title"].Value;
          string description = "";
          string keywords = "";
          GetMetaTagsDetails(row.link, out description, out keywords);%>
            <div class="grid_3">
							<div class="wrapper marTop9">
								<h3><a href="<%=row.link %>" class="link2"><%=title %></a></h3>
								<p><%=description.Length>270?description.Substring(0,270)+"...":description%></p>
							</div></div>
    <%} %>
                        </div>

				</div>
</asp:Content>
