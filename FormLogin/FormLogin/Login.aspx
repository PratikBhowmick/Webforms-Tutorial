<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FormLogin.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table style="border:solid">
        <tr>
            <td>Username :</td>
            <td><asp:TextBox ID="UserIdText" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Password :</td>
            <td><asp:TextBox ID="passwordText" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:CheckBox ID="checkBoxRemember" runat="server" Text="Remember me" /></td>
            <td><asp:Button ID="loginButton" runat="server" Text="Login" OnClick="btnlogin_click" /></td>
        </tr>
        <tr>
            <td><asp:Label ID="loginLabel" runat="server" Text="Label"></asp:Label></td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
