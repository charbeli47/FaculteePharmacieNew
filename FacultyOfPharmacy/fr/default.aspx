<%@ Page Title="" Language="C#" MasterPageFile="~/fr/fr.master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="FacultyOfPharmacy.fr._default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <div style="height:115px"></div>
    <div class="slider_wrapper">
								<div class="" id="camera_wrap">
                                    <%foreach (var img in homegallery)
                                      { %>
										<div data-src="../Media/<%=img.image %>">
												<div class="caption fadeIn">
														<div class="caption_bg" >
																<p class="txt2" style="color:#ffffff"><%=img.title %></p>
																<p style="color:#ffffff;"><%=img.description %></p>
														</div>
												</div>
										</div>
                                    <%} %>

			
								</div>
							</div>



<!--=======content================================-->

			<div class="wrapper marTop1">
				<div class="container">
					<div class="row">
						<div class="grid_4">
							<div class="banner1 bg1">
								<p class="txt3">EXCELLENCE</p>
								<p class="color1">On s'active à préparer les étudiants à un futur professionnel couronné de succès.</p>
								<%--<a href="#" class="link1 marTop2 fright"><i class="fa fa-arrow-circle-o-right icon1"></i></a>--%>
								<div class="clear"></div>
							</div>
						</div>

						<div class="grid_4">
							<div class="banner1 bg2">
								<p class="txt3">SOINS DE SANTÉ </p>
								<p class="color1">On prépare nos étudiants à être engagés en société prenant le patient comme partenaire.</p>
								<%--<a href="#" class="link1 marTop2 fleft color1"><i class="fa fa-arrow-circle-o-right icon1"></i></a>--%>
								<div class="clear"></div>
							</div>
						</div>

						<div class="grid_4">
							<div class="banner1 bg3">
								<p class="txt3">INNOVATION</p>
								<p class="color1">On s'engage à fournir un programme stimulant l'innovation et l'amélioration continue.</p>
								<%--<a href="#" class="link1 marTop2 fleft"><i class="fa fa-arrow-circle-o-right icon1"></i></a>--%>
								<div class="clear"></div>
							</div>
						</div>


					</div>
				</div>
			</div>


				<div class="container">

					<div class="row">

						<div class="grid_3">
							<%--<ul class="listWithMarker">
								<li><a href="#">Enroll in  Schools</a></li>
								<li><a href="#">Nutrition &amp; School Meals</a></li>
								<li><a href="#">Transportation</a></li>
								<li><a href="#">Directory</a></li>
								<li><a href="#">News &amp; Calendars</a></li>
								<li><a href="#">Family Resources</a></li>
								<li><a href="#">Councils &amp; Committees</a></li>
								<li><a href="#">Programs</a></li>
								<li><a href="#">Curriculum &amp; Standards</a></li>
								<li><a href="#">Services</a></li>
								<li><a href="#">Partnering</a></li>
								<li><a href="#">Safety &amp; Emergency Plan</a></li>
								<li><a href="#">Employee Resources</a></li>
								<li><a href="#">Employee Recognition</a></li>
							</ul>--%>

							<div class="box-1">
								<h2 class="marTop0">A Propos de Nous</h2>
								<p class="marTop3"><asp:Literal ID="aboutTxt" runat="server" /></p>
								<a href="history.aspx" class="more_btn">Plus d'info</a>
							</div>
						</div>

						<div class="grid_6">
							<h2>Nouvelles et Annonces</h2>
                            <%if(news.Count>0){ %>
                            <%foreach(var n in news){
                                  string weeksResponse = "";
                                  int weeks = (int)(DateTime.Now - n.date_in.Value).TotalDays / 7;
                                  if (weeks <= 1)
                                  {
                                      weeksResponse = "depuis " + ((int)(DateTime.Now - n.date_in.Value).TotalDays).ToString() + " jours";
                                  }
                                  else
                                  {
                                      weeksResponse = "depuis " + weeks + " semaines";
                                  } %>
							<div class="hline2">
								<p class="txt4"><%= weeksResponse%> </p>
								<p class="txt5"><a href="news-details.aspx?id=<%=n.id %>" class="link2"><%= n.frtitle %></a></p>
								<%--<div class="wrapper">
									<p class="txt6"><a href="#" class="link"><i class="fa fa-eye icon2"></i> 2,607</a></p>
									<p class="txt6"><a href="#" class="link"><i class="fa fa-comment icon2"></i> 107</a></p>
								</div>--%>
							</div>
                            <%} %>
							<%--<div class="hline2">
								<p class="txt4">3 weeks ago</p>
								<p class="txt5"><a href="#" class="link2">Conse ctetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna</a></p>
								<p>Lorem ipsum dolor sit amet conse ctetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam</p>
								<div class="wrapper">
									<p class="txt6"><a href="#" class="link"><i class="fa fa-eye icon2"></i> 2,607</a></p>
									<p class="txt6"><a href="#" class="link"><i class="fa fa-comment icon2"></i> 107</a></p>
								</div>
							</div>

							<div class="hline2">
								<p class="txt4">3 weeks ago</p>
								<p class="txt5"><a href="#" class="link2">Dolor sit amet conse ctetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna</a></p>
								<p>Lorem ipsum dolor sit amet conse ctetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam</p>
								<div class="wrapper">
									<p class="txt6"><a href="#" class="link"><i class="fa fa-eye icon2"></i> 2,607</a></p>
									<p class="txt6"><a href="#" class="link"><i class="fa fa-comment icon2"></i> 107</a></p>
								</div>
							</div>

							<div class="hline2">
								<p class="txt4">3 weeks ago</p>
								<p class="txt5"><a href="#" class="link2">Sit amet conse ctetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna</a></p>
								<p>Lorem ipsum dolor sit amet conse ctetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam</p>
								<div class="wrapper">
									<p class="txt6"><a href="#" class="link"><i class="fa fa-eye icon2"></i> 2,607</a></p>
									<p class="txt6"><a href="#" class="link"><i class="fa fa-comment icon2"></i> 107</a></p>
								</div>
							</div>--%>

							<p class="txt7"><a href="news.aspx">Plus d'info</a></p>
                            <%}
                              else{ %>
                            <p>Restez à l'écoute pour les dernières nouvelles.</p>
                            <%} %>
						</div>


						<div class="grid_3">
							<h2>Événements à venir</h2>
                            
                            <%if(events.Count>0){foreach(var e in events)
                              {  %>
							<a href="events-details.aspx?id=<%=e.id %>" class="link_img">
								<div class="img_section">
									<img src="../Media/<%=e.photo %>" alt="">
									<div class="img_section_txt">
										<p class="txt8"><%=string.Format("{0:dd/MM/yyyy hh:mm:ss tt}",e.date_start) %></p>
										<p class="txt9"><%=e.frtitle %> </p>
									</div>
								</div>
							</a>
                            <%} %>
							<%--<a href="#" class="link_img">
								<div class="img_section">
									<img src="../images/page1_pic2.jpg" alt="">
									<div class="img_section_txt">
										<p class="txt8">3/31/2014  -  8:00 AM</p>
										<p class="txt9">Ipsum dolor sit amet conse ctetur adipisicing </p>
									</div>
								</div>
							</a>

							<a href="#" class="link_img">
								<div class="img_section">
									<img src="../images/page1_pic3.jpg" alt="">
									<div class="img_section_txt">
										<p class="txt8">3/31/2014  -  8:00 AM</p>
										<p class="txt9">Excepteur sint occaecat cupidatat non proident</p>
									</div>
								</div>
							</a>--%>

							<p class="txt7"><a href="events.aspx">See all</a></p>
                            <%}else{ %>
                            <p>Restez à l'écoute pour les événements à venir</p>
                            <%} %>
						</div>



					</div>

				</div>

</asp:Content>
