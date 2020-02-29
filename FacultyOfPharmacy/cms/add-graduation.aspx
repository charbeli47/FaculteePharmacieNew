<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="add-graduation.aspx.cs" Inherits="FacultyOfPharmacy.cms.add_graduation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" src="js/jquery-1.7.2.min.js"></script>
    <script type="text/javascript" src="js/tiny_mce/tiny_mce.js"></script>
<script type="text/javascript">
    tinyMCE.init({
        // General options
        mode: "specific_textareas",
        editor_selector: "myTextEditor",
        theme: "advanced",
        plugins: "autolink,lists,pagebreak,style,layer,table,save,advhr,advimage,advlink,emotions,iespell,inlinepopups,insertdatetime,preview,media,searchreplace,print,contextmenu,paste,directionality,fullscreen,noneditable,visualchars,nonbreaking,xhtmlxtras,template,wordcount,advlist,autosave",

        // Theme options
        theme_advanced_buttons1: "save,newdocument,|,bold,italic,underline,strikethrough,|,justifyleft,justifycenter,justifyright,justifyfull,styleselect,formatselect,fontselect,fontsizeselect",
        theme_advanced_buttons2: "cut,copy,paste,pastetext,pasteword,|,search,replace,|,bullist,numlist,|,outdent,indent,blockquote,|,undo,redo,|,link,unlink,anchor,image,cleanup,help,code,|,insertdate,inserttime,preview,|,forecolor,backcolor",
        theme_advanced_buttons3: "tablecontrols,|,hr,removeformat,visualaid,|,sub,sup,|,charmap,emotions,iespell,media,advhr,|,print,|,ltr,rtl,|,fullscreen",
        theme_advanced_buttons4: "insertlayer,moveforward,movebackward,absolute,|,styleprops,|,cite,abbr,acronym,del,ins,attribs,|,visualchars,nonbreaking,template,pagebreak,restoredraft",
        theme_advanced_toolbar_location: "top",
        theme_advanced_toolbar_align: "left",
        theme_advanced_statusbar_location: "bottom",
        theme_advanced_resizing: true,

        // Example content CSS (should be your site CSS)
        content_css: "css/content.css",

        // Drop lists for link/image/media/template dialogs
        template_external_list_url: "lists/template_list.js",
        external_link_list_url: "lists/link_list.js",
        external_image_list_url: "lists/image_list.js",
        media_external_list_url: "lists/media_list.js",

        // Style formats
        style_formats: [
			{ title: 'Bold text', inline: 'b' },
			{ title: 'Red text', inline: 'span', styles: { color: '#ff0000' } },
			{ title: 'Red header', block: 'h1', styles: { color: '#ff0000' } },
			{ title: 'Example 1', inline: 'span', classes: 'example1' },
			{ title: 'Example 2', inline: 'span', classes: 'example2' },
			{ title: 'Table styles' },
			{ title: 'Table row 1', selector: 'tr', classes: 'tablerow1' }
        ],

        // Replace values for the template plugin
        template_replace_values: {
            username: "Some User",
            staffid: "991234"
        }
    });
</script>
</head>
<body>
    <center>
    <form id="form1" runat="server" target="_parent">
        <div id="Loged" runat="server">
    <table>
        <tr><td>Arabic name</td><td><asp:TextBox ID="arname" style="width:300px" runat="server" /><asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="arname" Text="Required field" ForeColor="Red" runat="server" /></td></tr>
        <tr><td>French name</td><td><asp:TextBox ID="frname" style="width:300px" runat="server" /><asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="frname" Text="Required field" ForeColor="Red" runat="server" /></td></tr>
        <tr><td>english name</td><td><asp:TextBox ID="enname" style="width:300px" runat="server" /><asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="enname" Text="Required field" ForeColor="Red" runat="server" /></td></tr>
        <tr><td>Small Arabic Text</td><td><asp:TextBox ID="smallartext" style="width:300px" runat="server" TextMode="MultiLine" /></td></tr>
        <tr><td>Small French Text</td><td><asp:TextBox ID="smallfrtext" style="width:300px" runat="server" TextMode="MultiLine" /></td></tr>
        <tr><td>Smallenglish Text</td><td><asp:TextBox ID="smallentext" style="width:300px" runat="server" TextMode="MultiLine" /></td></tr>
        <tr><td>Arabic Text</td><td><asp:TextBox ID="artext" style="width:300px" CssClass="myTextEditor" runat="server" TextMode="MultiLine" /></td></tr>
        <tr><td>French Text</td><td><asp:TextBox ID="frtext" style="width:300px" CssClass="myTextEditor" runat="server" TextMode="MultiLine" /></td></tr>
        <tr><td>english Text</td><td><asp:TextBox ID="entext" style="width:300px" CssClass="myTextEditor" runat="server" TextMode="MultiLine" /></td></tr>
        
        <tr><td colspan="2" align="left"><asp:Button ID="savebtn" Text="Save" 
            runat="server" onclick="savebtn_Click" /></td></tr>
    </table>
    </div>
    <div id="notLoged" runat="server">
    
    <label for="login">Username:</label>
	<input id="uname" name="uname" runat="server" class="text" /><br />
	<label for="pass">Password:</label>
	<input id="pass" name="pass" runat="server" type="password" class="text" />
	<div class="sep"></div>
    <asp:Button ID="loginButton" Text="Login" runat="server" 
            onclick="loginButton_Click" />
    </div>
    </form>
    </center>
    <asp:Literal ID="msg" runat="server" />
</body>
</html>
