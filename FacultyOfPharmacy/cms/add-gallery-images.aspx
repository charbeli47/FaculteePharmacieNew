<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="add-gallery-images.aspx.cs" Inherits="Web.cms.add_gallery_images" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="js/jquery.min.js"></script>
    
</head>
<body>
    <center>
    <form id="form1" runat="server" target="_parent">
    <div id="Loged" runat="server">
    <table>
        <tr><td>Title</td><td><asp:Textbox ID="title" runat="server" /><asp:RequiredFieldValidator ID="validator1" ControlToValidate="title" Text="This field is required" ForeColor="Red" runat="server" /></td></tr>
        <tr><td>Description</td><td><asp:TextBox ID="description" TextMode="MultiLine" runat="server"/></td></tr>
        <tr><td>Small image</td><td><asp:FileUpload ID="smallImage" runat="server" /></td></tr>
        <tr><td>Large image</td><td><asp:FileUpload ID="largeImage" runat="server" /></td></tr>
        <tr><td colspan="2" align="left"><asp:Button ID="savebtn" Text="Save" runat="server" onclick="savebtn_Click" /></td></tr>    
    </table>
        <%if(action=="edit"){ %>
        <h3>Add Images for this gallery by browsing for any image</h3>
        <input type="file" id="uploadFile" name="uploadFile" /><img src="img/loader_gif.gif" style="height:50px;display:none" id="loaderGif"/>
        <div id="imagePreview"><asp:Literal ID="Gallimages" runat="server" /></div>
        <%} %>
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
    <script>
        $(function () {
            $("#uploadFile").on("change", function () {
                $("#loaderGif").fadeIn();
                var files = !!this.files ? this.files : [];
                if (!files.length || !window.FileReader) return; // no file selected, or no FileReader support

                if (/^image/.test(files[0].type)) { // only image file
                    var reader = new FileReader(); // instance of the FileReader
                    reader.readAsDataURL(files[0]); // read the local file

                    reader.onloadend = function () { // set image data as background of div

                        var imRes = this.result;
                        $.ajax({
                            type: "POST",
                            url: "uploadGalleryImage.ashx",
                            data: { img: imRes, galleryId: '<%=Request["id"]%>' }
                        })
  .done(function (msg) {
      $("#loaderGif").fadeOut();
      document.getElementById("imagePreview").innerHTML += "<div id=\"" + msg + "\" style=\"background-image:url(" + imRes + ");width:200px;height:200px;background-size:cover;float:left;margin-left:5px;margin-top:5px\"><div onclick='deleteImg(\"" + msg + "\")' style='cursor:pointer;float:right;'><img src='img/i_delete.png'/></div></div>";
      document.getElementById("uploadFile").value = "";
  });
                    }
                }
            });
        });
        function deleteImg(id) {
            $.ajax({
                type: "POST",
                url: "deleteGalleryImage.ashx",
                data: { id: id }
            })
  .done(function (msg) {
      document.getElementById(id).style.display = "none";
  });
        }
    </script>
</body>
</html>
