<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sessionApplicationDemo.aspx.cs" Inherits="DemoStatemanagment.sessionApplicationDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
   <form id="form1" runat="server">
    <div>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        <br />
        <br />
        No of postback from starting to application &nbsp;(saved in Application) :
        <asp:Label ID="Label1" runat="server" ></asp:Label><br />

        No of postback (saved in Session) :<asp:Label ID="Label2" runat="server" ></asp:Label><br />

        Total No of Click on "Redirect to same Page" button (Saved in QueryString ):
        <asp:Label ID="Label3" runat="server" ></asp:Label><br />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Redirect to same Page" OnClick="Button2_Click" /></div>
    </form>
</body>
</html>
