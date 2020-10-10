<%@ Page Title="" Language="C#" MasterPageFile="~/webMaster.Master" AutoEventWireup="true" CodeBehind="pageChiTiet.aspx.cs" Inherits="QLyBanHang.pageChiTiet" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Repeater ID="Repeater2" runat="server">
        <ItemTemplate>
            <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("HinhAnh") %>' Height="100%" Width="100%" />
            <br>
            <p >Ten san pham: <%# Eval("TenSP") %></p>
            <br>
            <p >Don Gia: <%# Eval("DonGia") %></p>
        </ItemTemplate>
    </asp:Repeater>
    <asp:DropDownList ID="drl_SoLuong" runat="server">
    </asp:DropDownList>
    <asp:Button ID="btn_GioHang" runat="server" Text="Gio Hang" />
</asp:Content>
