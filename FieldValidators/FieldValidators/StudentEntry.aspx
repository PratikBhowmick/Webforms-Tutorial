<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentEntry.aspx.cs" Inherits="FieldValidators.StudentEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>        
    Name :<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
          <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ForeColor="Red" ControlToValidate="TextBox1" ErrorMessage="Name cannot be empty"></asp:RequiredFieldValidator><br />
    Age  :<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
          <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ForeColor="Red" ControlToValidate="TextBox2" ErrorMessage="Age cannot be empty"></asp:RequiredFieldValidator>
          <asp:RangeValidator ID="RangeValidator1" runat="server" ForeColor="Red" ControlToValidate="TextBox2" MaximumValue="80" MinimumValue="0" ErrorMessage="Age between 1 and 80"></asp:RangeValidator><br />
    Email :<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ValidationExpression="^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$" ForeColor="Red" ControlToValidate="TextBox3" ErrorMessage="Enter a valid mail id"></asp:RegularExpressionValidator><br />
        <asp:Button ID="Button1" runat="server" Text="Button" />
    </div>
    </form>
</body>
</html>
