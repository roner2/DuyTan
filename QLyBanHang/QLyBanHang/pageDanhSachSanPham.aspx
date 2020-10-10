<%@ Page Title="" Language="C#" MasterPageFile="~/webMaster.Master" AutoEventWireup="true" CodeBehind="pageDanhSachSanPham.aspx.cs" Inherits="QLyBanHang.pageDanhSachSanPham" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList1" runat="server" RepeatColumns="3">
        <ItemTemplate>
            <a href="pageChiTiet.aspx?IdSP=<%# Eval("IdSP") %>">
                <asp:Image ID="Image1" runat="server" Width="100%" Height="50%" ImageUrl='<%# Eval("HinhAnh") %>' />
                <br>            
                <p style="font-size: 20px; text-transform: uppercase">Tên Sản Phẩm: <%# Eval("TenSP") %> </p>
                <br>
                <p class="rainbow" style="font-size: 25px" >Đơn Giá: <%# Eval("DonGia") %> </p>
            </a>
        </ItemTemplate>
    </asp:DataList>
</asp:Content>
