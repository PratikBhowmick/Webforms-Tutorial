<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Demo_DataTransfer.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr>
            <td>Name :</td>
            <td><asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Email :</td>
            <td><asp:TextBox ID="TextBoxEmail" runat="server"></asp:TextBox></td>
        </tr>
        
        <tr>
            <td><asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" style="height: 26px" />
        </tr>
    </table>
    </div>
    </form>
</body>
</html>


