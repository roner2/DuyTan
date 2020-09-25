<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="webDangKy.aspx.vb" Inherits="WebQuanLyBanHang.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }
        .auto-style2 {
            height: 23px;
            width: 276px;
        }
        .auto-style3 {
            width: 276px;
        }
        .auto-style4 {
            width: 276px;
            height: 26px;
        }
        .auto-style5 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style2">Họ Tên (*)</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="TextBox3" runat="server" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Tên Đăng Nhập (*)</td>
                    <td>
                        <asp:TextBox ID="TextBox4" runat="server" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Mật Khẩu (*)</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TextBox5" runat="server" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Xác nhận Mật Khẩu (*)</td>
                    <td>
                        <asp:TextBox ID="TextBox6" runat="server" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Giới Tính</td>
                    <td>
                        <asp:CheckBox ID="Nam" runat="server" Text="Nam" />
                        <asp:CheckBox ID="Nu" runat="server" Text="Nữ" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Email</td>
                    <td>
                        <asp:TextBox ID="TextBox7" runat="server" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Địa Chỉ</td>
                    <td>
                        <asp:TextBox ID="TextBox8" runat="server" Height="42px" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Thông Tin Điều Khoản</td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Height="20px" Text="Đọc điều khoản" Width="100px" />
                        <br />
                        <asp:CheckBox ID="CheckBox1" runat="server" Text="Tôi chấp nhận điều khoản." />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td>
                        <asp:Button ID="Button2" runat="server" Height="35px" Text="Đăng Ký" Width="90px" />
&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button3" runat="server" Height="35px" Text="Hủy" Width="90px" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
