<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GridView.aspx.cs" Inherits="DemoGridView.GridView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body bgcolor="#669999">
    <form id="form1" runat="server">
        <h4>Demo Grid operations</h4>
        <table>
            <tr>
                <td>First Name</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

                </td>
            </tr>

            <tr>
                <td>Middle Name</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>

                </td>
            </tr>
            <tr>
                <td>Last Name</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>

                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Save" OnClick="empsave" />
                </td>
            </tr>
        </table>

        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <asp:HiddenField ID="HiddenField1" runat="server" />

        <asp:GridView ID="GridView1" runat="server" DataKeyNames="id" OnRowEditing="edit"
            OnRowCancelingEdit="canceledit"
            OnRowDeleting="delete"
            OnRowUpdating="update"
            CellPadding="4" ForeColor="#333333"
            GridLines="None">
            <AlternatingRowStyle BackColor="White" />

            <Columns>
                <asp:CommandField ShowEditButton="True" />
                <asp:CommandField ShowDeleteButton="True" />
            </Columns>
             <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <SortedAscendingCellStyle BackColor="#FDF5AC" />
            <SortedAscendingHeaderStyle BackColor="#4D0000" />
            <SortedDescendingCellStyle BackColor="#FCF6C0" />
            <SortedDescendingHeaderStyle BackColor="#820000" />
        </asp:GridView>
        </form>
    </body>
</html>
