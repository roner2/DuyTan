<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pageDanhMuc.aspx.cs" Inherits="QLyBanHang.pageDanhMuc" %>

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
            <br />
            Ma Danh Muc:&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lb_Ma" runat="server" Text="Label"></asp:Label>
        </div>
        Danh Muc:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txt_MaDM" runat="server"></asp:TextBox>
        <br />
        Ten Danh Muc:&nbsp;&nbsp;
        <asp:TextBox ID="txt_TenDM" runat="server" OnTextChanged="txt_TenDM_TextChanged"></asp:TextBox>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_Luu" runat="server" Height="41px" OnClick="Button1_Click" Text="Luu" Width="95px" />
&nbsp;<p>
            &nbsp;</p>
    </form>
</body>
</html>
