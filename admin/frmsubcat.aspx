<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="frmsubcat.aspx.cs" Inherits="admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td style="font-size: medium; width: 155px"><strong>Select Category</strong></td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="ObjectDataSource1" DataTextField="catnam" DataValueField="catcod" Width="148px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="font-size: medium; width: 155px"><strong>Sub Category</strong></td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Width="140px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2"><strong>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="font-size: medium; font-weight: bold" Text="submit" />
                <asp:Button ID="Button2" runat="server" style="font-size: medium; font-weight: bold" Text="cancel" />
                </strong></td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" DataKeyNames="subcatcod" DataSourceID="ObjectDataSource2" ForeColor="Black" GridLines="None" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing">
                    <AlternatingRowStyle BackColor="PaleGoldenrod" />
                    <Columns>
                        <asp:BoundField DataField="subcatnam" HeaderText="Sub Category" SortExpression="subcatnam" />
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
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="disp_rec" TypeName="nsgumtree.clscat"></asp:ObjectDataSource>
                <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="disp_rec" TypeName="nsgumtree.clssubcat">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="DropDownList1" Name="catcod" PropertyName="SelectedValue" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </td>
        </tr>
    </table>
</asp:Content>

