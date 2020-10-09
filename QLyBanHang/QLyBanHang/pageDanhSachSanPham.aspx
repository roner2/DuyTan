<%@ Page Title="" Language="C#" MasterPageFile="~/webMaster.Master" AutoEventWireup="true" CodeBehind="pageDanhSachSanPham.aspx.cs" Inherits="QLyBanHang.pageDanhSachSanPham" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList1" runat="server" RepeatColumns="3">
        <ItemTemplate>
            <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("HinhAnh") %>' width:50% height:50% />
            <br>
            Tên Sản Phẩm: <%# Eval("TenSP") %>
            <br>
            Đơn Giá: <%# Eval("DonGia") %>
        </ItemTemplate>
    </asp:DataList>
</asp:Content>
