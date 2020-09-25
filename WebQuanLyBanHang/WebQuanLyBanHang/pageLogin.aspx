<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="pageLogin.aspx.vb" Inherits="WebQuanLyBanHang.pageLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 155px;
        }
        .auto-style2 {
            margin-left: 86px;
        }
        .auto-style3 {
            width: 214px;
        }
        .auto-style4 {
            width: 100%;
            height: 135px;
        }
        .auto-style5 {
            width: 155px;
            height: 40px;
        }
        .auto-style6 {
            width: 214px;
            height: 40px;
        }
        .auto-style7 {
            height: 40px;
        }
        .auto-style8 {
            width: 155px;
            height: 42px;
        }
        .auto-style9 {
            width: 214px;
            height: 42px;
        }
        .auto-style10 {
            height: 42px;
        }
        .auto-style11 {
            width: 155px;
            height: 21px;
        }
        .auto-style12 {
            width: 214px;
            height: 21px;
        }
        .auto-style13 {
            height: 21px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style4">
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">Tên Đăng Nhập</td>
                <td class="auto-style9">
                    <asp:TextBox ID="TextBox1" runat="server" Width="215px"></asp:TextBox>
                </td>
                <td class="auto-style10">
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Mật Khẩu</td>
                <td class="auto-style6">
                    <asp:TextBox ID="TextBox2" runat="server" Width="215px"></asp:TextBox>
                </td>
                <td class="auto-style7">
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style11"></td>
                <td class="auto-style12">
                </td>
                <td class="auto-style13"></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style3">
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style3">
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <div>
            <asp:Button ID="Button1" runat="server" CssClass="auto-style2" Text="Đăng Nhập" Width="133px" />
        </div>
    </form>
</body>
</html>
