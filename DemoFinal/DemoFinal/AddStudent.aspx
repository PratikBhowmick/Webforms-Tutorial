<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddStudent.aspx.cs" Inherits="DemoFinal.AddStudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 445px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 style="color:aqua;">Welcome to student registration system</h1>
        </div>
    <div>
    <table border="1" style="background-color:burlywood" class="auto-style1">
        <tr>
            <td>Name :</td>
            <td>
            <asp:TextBox ID="TextBoxName" runat="server" ViewStateMode="Disabled"></asp:TextBox></td>
        </tr>
        <tr>
            <td>City :</td>
            <td>
            <asp:TextBox ID="TextBoxCity" runat="server" ViewStateMode="Disabled"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Subject :</td>
            <td>
            <asp:TextBox ID="TextBoxSubject" runat="server" ViewStateMode="Disabled"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Marks :</td>
            <td>
            <asp:TextBox ID="TextBoxMarks" runat="server" ViewStateMode="Disabled"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Button ID="Clear" runat="server" Text="Clear" OnClick="Clear_Click" /></td>
             <td><asp:Button ID="Submit" runat="server" Text="Submit" OnClick="Submit_Click" /></td>
        </tr>
        <tr><asp:Label ID="LabelMessage" runat="server" Text="Label"></asp:Label></tr>
    </table>
    </div>

        <p>
            <a href="ViewStudent.aspx">Click Here to go to repository </a>            
        </p>
    </form>
</body>
</html>
