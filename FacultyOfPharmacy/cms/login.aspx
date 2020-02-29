<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="FacultyOfPharmacy.cms.login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" lang="pl" xml:lang="pl">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8" />
<title>Faculty Of Pharmacy CMS</title>
<link rel="stylesheet" type="text/css" href="css/login.css" media="screen" />
</head>
<body>
<div class="wrap">
	<div id="content">
		<div id="main">
			<div class="full_w">
				<form runat="server">
					<label for="login">Username:</label>
					<input id="uname" name="uname" runat="server" class="text" />
					<label for="pass">Password:</label>
					<input id="pass" name="pass" runat="server" type="password" class="text" />
					<div class="sep"></div>
                    <asp:Label ID="msg" runat="server" />
					<button type="submit" class="ok">Login</button> <a class="button" href="">Forgotten password?</a>
				</form>
			</div>
			<div class="footer">&raquo; <a>FacultyOfPharmacy</a> | CMS</div>
		</div>
	</div>
</div>

</body>
</html>
