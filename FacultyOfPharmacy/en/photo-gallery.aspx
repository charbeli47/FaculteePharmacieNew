<%@ Page Title="" Language="C#" MasterPageFile="~/en/en.master" AutoEventWireup="true" CodeBehind="photo-gallery.aspx.cs" Inherits="FacultyOfPharmacy.en.photo_gallery" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!-- Font Awesome -->
	<link rel="stylesheet" href="http://maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css">
	<!-- Pixel Fabric clothes icons -->
	<link rel="stylesheet" type="text/css" href="../fonts/pixelfabric-clothes/style.css" />
	 <!-- Flickity gallery styles -->
	<link rel="stylesheet" type="text/css" href="../css/flickity.css" />
	<!-- Component styles -->
	<link rel="stylesheet" type="text/css" href="../css/component.css" />
    <link rel="stylesheet" type="text/css" href="../css/gallery.css" />
	<script src="../js/modernizr.custom.js"></script>
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    
    <div id="content" class="row">
<div data-motopress-type="loop" data-motopress-loop-file="loop/loop-portfolio3.php">
<div class="page_content">
<div class="clear"></div>
</div>
<div class="filter-wrapper clearfix">
<div>
<ul id="filters" class="filter nav nav-pills">
<li class="active"><a href="#" data-count="13" data-filter>All</a></li>
    <%foreach(var category in categories){ %>
<li><a href="#" data-count="4" data-filter=".term_id_<%=category.id %>"><%=category.title %></a></li>
    <%} %>
    <%--<li><a href="#" data-count="8" data-filter=".term_id_21">Category 2</a></li><li><a href="#" data-count="5" data-filter=".term_id_22">Category 3</a></li>--%> </ul>
<div class="clear"></div>
</div>
</div>
<ul id="portfolio-grid" class="filterable-portfolio thumbnails portfolio-3cols" data-cols="3cols">
<script>
    jQuery(document).ready(function ($) {
        var $container = $('#portfolio-grid'),
			items_count = $(".portfolio_item").size();

        $(window).load(function () {
            var selector = window.location.hash.replace(/^#category/, '.term');

            if (selector == "#") {
                selector = '';
            }

            setColumnWidth();
            $container.isotope({
                itemSelector: '.portfolio_item',
                hiddenClass: 'portfolio_hidden',
                resizable: false,
                transformsEnabled: true,
                layoutMode: 'fitRows',
                filter: selector
            })

            $('#filters .active').removeClass('active')
            $('#filters li a[data-filter="' + selector + '"]').parent('li').addClass('active');
            change_hash(selector);

            $(window).on("debouncedresize", function (event) {
                arrange();
            });
        });

        function getNumColumns() {
            var $folioWrapper = $('#portfolio-grid').data('cols');

            if ($folioWrapper == '2cols') {
                var winWidth = $("#portfolio-grid").width(),
					column = 2;
                if (winWidth < 380) column = 1;
                return column;
            }

            else if ($folioWrapper == '3cols') {
                var winWidth = $("#portfolio-grid").width(),
					column = 3;
                if (winWidth < 380) column = 1;
                else if (winWidth >= 380 && winWidth < 788) column = 2;
                else if (winWidth >= 788 && winWidth < 1160) column = 3;
                else if (winWidth >= 1160) column = 3;
                return column;
            }

            else if ($folioWrapper == '4cols') {
                var winWidth = $("#portfolio-grid").width(),
					column = 4;
                if (winWidth < 380) column = 1;
                else if (winWidth >= 380 && winWidth < 788) column = 2;
                else if (winWidth >= 788 && winWidth < 1160) column = 3;
                else if (winWidth >= 1160) column = 4;
                return column;
            }
        }

        function setColumnWidth() {
            var columns = getNumColumns(),
				containerWidth = $("#portfolio-grid").width(),
				postWidth = containerWidth / columns;
            postWidth = Math.floor(postWidth);

            $(".portfolio_item").each(function (index) {
                $(this).css({ "width": postWidth + "px" });
            });
        }

        function arrange() {
            setColumnWidth();
            $container.isotope('reLayout');
        }

        // Filter projects
        $('.filter a').click(function () {
            var $this = $(this).parent('li');
            // don't proceed if already active
            if ($this.hasClass('active')) {
                return;
            }


            var $optionSet = $this.parents('.filter');
            // change active class
            $optionSet.find('.active').removeClass('active');
            $this.addClass('active');

            var selector = $(this).attr('data-filter');
            $container.isotope({ filter: selector });
            change_hash(selector)

            var hiddenItems = 0,
				showenItems = 0;
            $(".portfolio_item").each(function () {
                if ($(this).hasClass('portfolio_hidden')) {
                    hiddenItems++;
                };
            });

            showenItems = items_count - hiddenItems;
            if (($(this).attr('data-count')) > showenItems) {
                $(".pagination__posts").css({ "display": "block" });
            } else {
                $(".pagination__posts").css({ "display": "none" });
            }
            return false;
        });
        function change_hash(hash) {
            hash = hash.replace(/^.term/, 'category');
            window.location.href = '#' + hash;

            $('.pagination a').each(function () {
                var item = $(this),
					href = item.attr('href'),
					end_slice = href.indexOf('#') == -1 ? href.length : href.indexOf('#');

                href = href.slice(0, end_slice);
                item.attr({ 'href': href + '#' + hash })
            })
        }
    });
</script>
    <%foreach (var project in gallery)
        {
            List<Utils.CMSGetGalleryImagesByGalleryIDResult> images = dc.CMSGetGalleryImagesByGalleryID(project.id).ToList();  %>
<li class="portfolio_item  term_id_<%=project.categoryId %>">
<div class="portfolio_item_holder">
<figure class="thumbnail thumbnail__portfolio" style="height:200px;overflow:hidden">
<a href="javascript:popitUp('<%=project.id %>')" onclick="popitUp('<%=project.id %>')"  title="" >
<img src="../Media/<%=project.SmallImage %>" alt="<%=project.title %>"/>
<span class="zoom-icon"></span> </a>
</figure> 
   
<div style="text-align:center">
<a><%=project.title %></a>
<p class="excerpt"> </p>
</div> 
</div> 
</li> 
    <%} %> 
</ul>
    <script src="../js/jquery.bpopup.min.js"></script>
    <script>
        function popitUp(id) {
            $('#popup2').bPopup({
                content:'iframe',
                contentContainer: '.content',
                loadUrl: 'gallery-details.aspx?id=' + id
            });
        }
    </script>
    <div id="popup2">
        <div class="b-close" style="margin-top:10px;color:white;cursor:pointer;font-size:15px;font-weight:bold">X</div>
        <div class="content"></div>
    </div>
  </div>
</div>
    <script type="text/javascript" src="../js/isotope.pkgd.min.js"></script>
</asp:Content>