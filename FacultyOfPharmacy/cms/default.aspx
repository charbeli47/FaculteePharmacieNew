<%@ Page Title="" Language="C#" MasterPageFile="~/cms/cms.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="FacultyOfPharmacy.cms._default" %>
<asp:Content ContentPlaceHolderID="main" runat="server">
<script type="text/javascript">
    $(function () {
        $(".box .h_title").not(this).next("ul").hide("normal");
        $(".box .h_title").not(this).next("#home").show("normal");
        $(".box").children(".h_title").click(function () { $(this).next("ul").slideToggle(); });
    });
</script>
<div id="main" align="left">
			<div class="half_w half_left">
				<div class="h_title">Visits statistics</div>
					<script src="js/highcharts_init.ashx"></script>
					<div id="container" style="min-width: 300px; height: 180px; margin: 0 auto"></div>
					<script src="js/highcharts.js"></script>
			</div>
			<div class="half_w half_right">
				<div class="h_title">Site statistics</div>
				<div class="stats">
					<div class="today">
						<h3>Today</h3>
						<p class="count"><%=visitsToday %></p>
						<p class="type">Visits</p>
					</div>
					<div class="week">
						<h3>Last week</h3>
						<p class="count"><%=visitsLastWeek %></p>
						<p class="type">Visits</p>
					</div>
				</div>
			</div>
            <div class="clear"></div>
			<div class="half_w half_left">
				<div class="h_title">Visits per browser</div>
				<div class="stats">
					<div class="today">
						<h3></h3>
						<p class="count"><%=visitsChrome %></p>
						<p class="type">Google Chrome</p>
                        <p class="count"><%=visitsFirefox %></p>
						<p class="type">Mozilla Firefox</p>
					</div>
					<div class="week">
						<h3></h3>
						<p class="count"><%=visitsIE %></p>
						<p class="type">Internet Explorer</p>
                        <p class="count"><%=visitsSafari %></p>
						<p class="type">Safari</p>
					</div>
				</div>
			</div>
			<div class="clear"></div>
			

		</div>
</asp:Content>