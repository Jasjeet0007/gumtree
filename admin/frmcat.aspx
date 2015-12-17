<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="frmcat.aspx.cs" Inherits="admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
    <tr>
        <td style="width: 84px; font-size: medium;"><strong>Category</strong></td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server" Width="159px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td colspan="2" style="margin-left: 160px">
            <strong>
            <asp:Button ID="Button1" runat="server" Text="submit" OnClick="Button1_Click" style="font-size: medium; font-weight: bold" />
            <asp:Button ID="Button2" runat="server" Text="cancel" style="font-size: medium; font-weight: bold" />
            </strong>
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" DataKeyNames="catcod" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" Width="223px">
                <Columns>
                    <asp:BoundField DataField="catnam" HeaderText="Category" SortExpression="catnam" />
                    <asp:CommandField />
                    <asp:CommandField ShowEditButton="True" />
                    <asp:CommandField ShowDeleteButton="True" />
                </Columns>
            </asp:GridView>
        </td>
    </tr>
    </table>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="disp_rec" TypeName="nsgumtree.clscat"></asp:ObjectDataSource>
</asp:Content>

