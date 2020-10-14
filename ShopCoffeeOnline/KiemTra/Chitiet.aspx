<%@ Page Title="" Language="C#" MasterPageFile="~/webMaster.Master" AutoEventWireup="true" CodeBehind="Chitiet.aspx.cs" Inherits="KiemTra.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Repeater ID="Repeater2" runat="server" OnItemCommand="Repeater2_ItemCommand">
        <ItemTemplate>
            <table border="1" style="width:100%;">
                <tr>
                    <td>
                        <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("HINHANH") %>' Height="500px" Width="500px" />
                    </td>
                    <td>
                        <h >Ten Đồ Uống: <%# Eval("TENDOUONG") %></h>                          
                        <p >Don Giá: <%# Eval("DONGIA") %></p>
                        <p >Chi Tiết: <%# Eval("MOTA") %></p>
                        <asp:DropDownList ID="drl_SoLuong" runat="server" AutoPostBack="True" Height="25px" Width="60px">
                            <asp:ListItem>1</asp:ListItem>
                            <asp:ListItem Value="2">2</asp:ListItem>
                            <asp:ListItem>3</asp:ListItem>
                            <asp:ListItem>4</asp:ListItem>
                            <asp:ListItem>5</asp:ListItem>
                            <asp:ListItem>6</asp:ListItem>
                            <asp:ListItem>7</asp:ListItem>
                            <asp:ListItem>8</asp:ListItem>
                            <asp:ListItem>9</asp:ListItem>
                            <asp:ListItem>10</asp:ListItem>        
                        </asp:DropDownList>
                        <asp:Button ID="btn_ThemGioHang" runat="server" Text="Them vao Gio Hang" />
                     </td>
                </tr>
            </table>            
        </ItemTemplate>
    </asp:Repeater>
    
    
</asp:Content>
