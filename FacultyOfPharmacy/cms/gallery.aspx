<%@ Page Title="" Language="C#" MasterPageFile="~/cms/cms.Master" AutoEventWireup="true" CodeBehind="gallery.aspx.cs" Inherits="Web.cms.gallery" %>
<asp:Content ID="Content1" ContentPlaceHolderID="main" runat="server">
    <script type="text/javascript">
        $(function () {
            $(".box .h_title").not(this).next("ul").hide("normal");
            $(".box .h_title").not(this).next("#home").show("normal");
            $(".box").children(".h_title").click(function () { $(this).next("ul").slideToggle(); });
        });
</script>
<script type='text/javascript' src='https://ajax.googleapis.com/ajax/libs/jquery/1.7.2/jquery.min.js'></script>
  <script src="colorbox/colorbox.js"></script>
  <link rel="stylesheet" href="colorbox/colorbox.css" />
<script>
    $(document).ready(function () {
        //Examples of how to assign the ColorBox event to elements
        $(".group1").colorbox({ rel: 'group1' });
        $(".group2").colorbox({ rel: 'group2', transition: "fade" });
        $(".group3").colorbox({ rel: 'group3', transition: "none", width: "75%", height: "75%" });
        $(".group4").colorbox({ rel: 'group4', slideshow: true });
        $(".ajax").colorbox();
        $(".youtube").colorbox({ iframe: true, innerWidth: 425, innerHeight: 344 });
        $(".iframe").colorbox({ iframe: true, width: "600px", height: "600px" });
        $(".imiframe").colorbox({ iframe: true, width: "100%", height: "100%" });
        $(".inline").colorbox({ inline: true, width: "50%" });
        $(".callbacks").colorbox({
            onOpen: function () { alert('onOpen: colorbox is about to open'); },
            onLoad: function () { alert('onLoad: colorbox has started to load the targeted content'); },
            onComplete: function () { alert('onComplete: colorbox has displayed the loaded content'); },
            onCleanup: function () { alert('onCleanup: colorbox has begun the close process'); },
            onClosed: function () { alert('onClosed: colorbox has completely closed'); }
        });

        //Example of preserving a JavaScript event for inline calls.
        $("#click").click(function () {
            $('#click').css({ "background-color": "#f00", "color": "#fff", "cursor": "inherit" }).text("Open this window again and this message will still be here.");
            return false;
        });
    });

		</script>
    <script type="text/javascript" src="http://code.jquery.com/ui/1.8.18/jquery-ui.min.js"></script>
  <script type='text/javascript'>//<![CDATA[
      $(window).load(function () {
          var fixHelperModified = function (e, tr) {
              var $originals = tr.children();
              var $helper = tr.clone();
              $helper.children().each(function (index) {
                  $(this).width($originals.eq(index).width())
              });
              return $helper;
          },
    updateIndex = function (e, ui) {
        $('td.index', ui.item.parent()).each(function (i) {
            $(this).html(i + 1);
            $.ajax({
                url: "update-sorting.aspx?table=GalleryCategories&id=" + $(this).html(i + 1)[0].parentNode.cells[0].id + "&sort=" + $(this).html(i + 1)[0].parentNode.cells[0].innerHTML,
                type: "GET"
            });
        });
    };
          $("#sort tbody").sortable({
              helper: fixHelperModified,
              stop: updateIndex
          }).disableSelection();
      });
    </script>
    <form id="Form1" runat="server">
        <h1>Projects Gallery</h1>
<asp:Literal ID="DeleteMsg" runat="server" />
<div style="width:500px;text-align:right;margin-left:357px" id="AddBtn" runat="server"><a href="add-gallery.aspx?action=add" class="iframe"><img src="img/i_add.png" /></a></div>
<table id="sort" class="grid" width="500" title="Drag any row to reorder">

    <thead>
        <tr><th class="index">ORDER</th><th>Title</th><th>&nbsp;</th></tr>
    </thead>
    <tbody>
    <%foreach (Utils.CMSGetGalleryCategoriesResult row in result)
      { %>
        <tr><td class="index" id="<%=row.id %>"><%=row.sort%></td>
        <td><%=row.title%></td>
        <td><%if (Session["User"] != null){ %><a href="add-gallery.aspx?action=edit&id=<%=row.id %>" class="iframe"><img src="img/i_edit.png" title="Edit" /></a>&nbsp;&nbsp;<a href="javascript:void()" onclick="if(confirm('Are you sure you want to delete this row?')==true){window.location.href='delete-table.aspx?id=<%=row.id %>&table=GalleryCategories&redirect_url=gallery.aspx'}"><img src="img/i_delete.png" title="Delete" /></a><a href="gallery-images.aspx?categoryId=<%=row.id %>" title="Gallery Images"><img src="img/i_photo.png" title="Gallery Images"/></a><%} %></td></tr>
        <%} %>
    </tbody>
</table>
        </form>
</asp:Content>

