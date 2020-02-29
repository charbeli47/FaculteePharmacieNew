<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="add-graduation-category.aspx.cs" Inherits="FacultyOfPharmacy.cms.add_graduation_category" %>

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
        <tr><td>Arabic name</td><td><asp:TextBox ID="arname" style="width:300px" runat="server" /><asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="arname" Text="Required field" ForeColor="Red" runat="server" /></td></tr>
        <tr><td>French name</td><td><asp:TextBox ID="frname" style="width:300px" runat="server" /><asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="frname" Text="Required field" ForeColor="Red" runat="server" /></td></tr>
        <tr><td>english name</td><td><asp:TextBox ID="enname" style="width:300px" runat="server" /><asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="enname" Text="Required field" ForeColor="Red" runat="server" /></td></tr>
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
