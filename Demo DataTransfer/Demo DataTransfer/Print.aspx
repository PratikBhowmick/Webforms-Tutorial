<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Print.aspx.cs" Inherits="Demo_DataTransfer.Print" %>

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
                <td><asp:Label ID="LabelName" runat="server" Text="Label"></asp:Label></td>
            </tr>
            <tr>
                <td>Email :</td>
                <td> <asp:Label ID="LabelEmail" runat="server" Text="Label"></asp:Label> </td>
            </tr>
        </table>
    </div>
    </form>
    
</body>
</html>
