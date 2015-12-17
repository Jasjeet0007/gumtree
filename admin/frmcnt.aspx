<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="frmcnt.aspx.cs" Inherits="admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td style="font-size: medium; width: 78px"><strong>Country</strong></td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Width="169px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2"><strong>
                <asp:Button ID="Button1" runat="server" style="font-size: medium; font-weight: bold" Text="submit" OnClick="Button1_Click1" />
                <asp:Button ID="Button2" runat="server" style="font-size: medium; font-weight: bold" Text="cancel" />
                </strong></td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" DataKeyNames="cntcod" DataSourceID="ObjectDataSource1" ForeColor="Black" GridLines="None" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing">
                    <AlternatingRowStyle BackColor="PaleGoldenrod" />
                    <Columns>
                        <asp:BoundField DataField="cntnam" HeaderText="Country Name" SortExpression="cntnam" />
                        <asp:CommandField />
                        <asp:CommandField ShowEditButton="True" />
                        <asp:CommandField ShowDeleteButton="True" />
                    </Columns>
                    <FooterStyle BackColor="Tan" />
                    <HeaderStyle BackColor="Tan" Font-Bold="True" />
                    <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                    <SortedAscendingCellStyle BackColor="#FAFAE7" />
                    <SortedAscendingHeaderStyle BackColor="#DAC09E" />
                    <SortedDescendingCellStyle BackColor="#E1DB9C" />
                    <SortedDescendingHeaderStyle BackColor="#C2A47B" />
                </asp:GridView>
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="disp_rec" TypeName="nsgumtree.clscnt"></asp:ObjectDataSource>
            </td>
        </tr>
    </table>
</asp:Content>

