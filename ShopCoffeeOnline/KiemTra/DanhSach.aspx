<%@ Page Title="" Language="C#" MasterPageFile="~/webMaster.Master" AutoEventWireup="true" CodeBehind="DanhSach.aspx.cs" Inherits="KiemTra.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList1" runat="server" RepeatColumns="3">
        <ItemTemplate>
            <table border="1" style="width:100%;">
                
                    <tr>
                        <td>
                            <a href="ChiTiet.aspx?MADOUONG=<%# Eval("MADOUONG") %>">
                                <asp:Image ID="Image1" runat="server" Width="350px" Height="350px" ImageUrl='<%# Eval("HINHANH") %>' />
                                <p style="font-size: 20px; text-transform: uppercase">Tên:  <%# Eval("TENDOUONG") %> </p>     
                            </a>
                        </td>
                    </tr>                
            </table>
            
        </ItemTemplate>
    </asp:DataList>
</asp:Content>
