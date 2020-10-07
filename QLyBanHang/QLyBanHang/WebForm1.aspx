<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="QLyBanHang.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </div>
        <asp:TextBox ID="txt_nhap" runat="server" BorderStyle="Inset"></asp:TextBox>
        <asp:Button ID="btn_button1" runat="server" OnClick="btn_button1_Click" Text="Button" />
    </form>
</body>
</html>
