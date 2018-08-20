<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserControl.ascx.cs" Inherits="UserControlDemo.UserControl" %>
<asp:TextBox ID="TextBox1" runat="server" AutoPostBack="True"></asp:TextBox>
<asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/calender.jpg" OnClick="ImageButton1_Click" Width="16px" />
&nbsp;<asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>

