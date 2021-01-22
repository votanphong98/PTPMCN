<%@ Page Language="C#" MasterPageFile="~/MasterPage_Admin.master" AutoEventWireup="true" CodeBehind="ThongKe.aspx.cs" Inherits="QuanLyCuaHangSach.ThongKe" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style3
        {
            width: 100%;
        }
        .style4
        {
            width: 280px;
        }
        .style5
        {
            width: 122px;
        }
        .style6
        {
        }
        .style7
        {
            width: 65px;
            height: 14px;
        }
        .style11
        {
            height: 14px;
        }
        .style12
        {
            width: 280px;
            height: 14px;
        }
        .style13
        {
            width: 122px;
            height: 14px;
        }
        .auto-style5 {
            width: 81px;
            height: 14px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table cellspacing="1" class="style3" width="100%">
        <tr>
            <td align="center" colspan="4" 
                style="background-color: #9999FF; font-weight: bold">
                THỐNG KÊ DOANH THU</td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Label ID="Label1" runat="server" Text="Doanh thu trong ngày"></asp:Label>
                &nbsp;</td>
            <td class="style12">
                <asp:Button ID="btnXem" runat="server" Text="Xem" Width="65px" OnClick="btnXem_Click" />
            </td>
            <td class="style13">
            </td>
            <td class="style11">
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Label ID="Label2" runat="server" Text="Ngày bắt đầu"></asp:Label>
            </td>
            <td class="style12"><asp:TextBox ID="txtSelectDateFirst" runat="server" TextMode="Date"></asp:TextBox></td>
            <td class="style13">
                &nbsp;</td>
            <td class="style11">
                &nbsp;</td>
        </tr><tr>
            <td class="auto-style5">
                <asp:Label ID="Label4" runat="server" Text="Ngày kết thúc"></asp:Label>
            </td>
            <td class="style12"><asp:TextBox ID="txtSelectDateLast" runat="server" TextMode="Date"></asp:TextBox></td>
            <td class="style13">
                &nbsp;</td>
            <td class="style11">
                &nbsp;</td>
        </tr>
         <tr>
            <td class="auto-style5">
                &nbsp;</td>
            <td class="style12">
                <asp:Button ID="btnXemTheoNgay" runat="server" Text="Xem" Width="65px" OnClick="btnXemTheoNgay_Click" />
             &nbsp;<asp:Label ID="lblMessage" runat="server" ForeColor="#CC3300"></asp:Label>
             </td>
            <td class="style13">
                &nbsp;</td>
            <td class="style11">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style6" colspan="4">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                    BackColor="White" BorderColor="#999999" BorderWidth="1px" 
                    CellPadding="3" GridLines="Vertical" Width="100%" BorderStyle="None">
                    <AlternatingRowStyle BackColor="#DCDCDC" />
                    <Columns>
                        <asp:BoundField DataField="MaHD" HeaderText="MaHD" />
                        <asp:BoundField DataField="HoTen" HeaderText="Tên Khách Hàng" />
                        <asp:BoundField DataField="TenSach" HeaderText="Tên Sách" />
                        <asp:BoundField DataField="DonGia" HeaderText="Đơn Giá" />
                        <asp:BoundField DataField="SoLuong" HeaderText="Số lượng" />
                        <asp:BoundField DataField="TongTien" HeaderText="Thành Tiền" />
                        <asp:BoundField DataField="NgayBan" HeaderText="Ngày Bán" />
                    </Columns>
                    <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#999999" ForeColor="Black" 
                        HorizontalAlign="Center" />
                    <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                    <SelectedRowStyle BackColor="#008A8C" ForeColor="White" Font-Bold="True" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#0000A9" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#000065" />
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td  colspan="4"><asp:Label ID="lblTongSoTien" runat="server" Font-Bold="True"></asp:Label></td>
        </tr>
    </table>
</asp:Content>
