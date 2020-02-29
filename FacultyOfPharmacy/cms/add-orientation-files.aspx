<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="add-orientation-files.aspx.cs" Inherits="FacultyOfPharmacy.cms.add_orientation_files" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
</head>
<body>
<center>
    <form id="form1" runat="server" target="_parent">
    <div id="Loged" runat="server">
    <table>
    <tr><td>File</td><td><asp:FileUpload ID="file" runat="server" /></td></tr>
        <tr><td>English Title</td><td><asp:TextBox ID="title" runat="server" /></td></tr>
        <tr><td>French Title</td><td><asp:TextBox ID="frtitle" runat="server" /></td></tr>
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
