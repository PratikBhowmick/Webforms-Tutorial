<%@ Page Language="C#"  AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DemoFileUpload._Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>    
    <asp:FileUpload ID="FileUpload1" runat="server" />&nbsp;<asp:Button ID="Button1" runat="server" Text="Upload file" OnClick="Button1_Click" />
    <br/>
    <br />
    <asp:Label ID="Label1" runat="server" font-bold="true"></asp:Label>
    </div>
    </form>
</body>
</html>
