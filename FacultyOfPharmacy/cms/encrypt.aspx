<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="encrypt.aspx.cs" Inherits="FacultyOfPharmacy.cms.encrypt" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:TextBox ID="inputField" runat="server" OnTextChanged="encryptText" AutoPostBack="true"/>
    <asp:Literal ID="encryptionField" runat="server" />
    </div>
    </form>
</body>
</html>
