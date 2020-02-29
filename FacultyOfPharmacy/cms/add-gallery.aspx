<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="add-gallery.aspx.cs" Inherits="Web.cms.add_gallery" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <center>
    <form id="form1" runat="server" target="_parent">
    <div id="Loged" runat="server">
    <table>
        <tr><td>Title</td><td><asp:Textbox ID="title" runat="server" /><asp:RequiredFieldValidator ID="validator1" ControlToValidate="title" Text="This field is required" ForeColor="Red" runat="server" /></td></tr>
        <tr><td colspan="2" align="left"><asp:Button ID="savebtn" Text="Save" runat="server" onclick="savebtn_Click" /></td></tr>    
    </table></div>
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
