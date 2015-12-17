<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="frmpln.aspx.cs" Inherits="admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td colspan="2" style="font-size: medium"><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Featured Advertisement Plans</strong></td>
        </tr>
        <tr>
            <td style="width: 187px; font-size: medium"><strong>Select Category</strong></td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="ObjectDataSource1" DataTextField="catnam" DataValueField="catcod" Height="16px" Width="134px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 187px; font-size: medium"><strong>Select Sub Category</strong></td>
            <td>
                <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" DataSourceID="ObjectDataSource2" DataTextField="subcatnam" DataValueField="subcatcod" Height="16px" Width="134px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 187px; font-size: medium"><strong>Plancost</strong></td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Width="126px"></asp:TextBox>
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
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" DataKeyNames="plncod" DataSourceID="ObjectDataSource3" ForeColor="Black" GridLines="None" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" Width="350px">
                    <AlternatingRowStyle BackColor="PaleGoldenrod" />
                    <Columns>
                        <asp:BoundField DataField="catnam" HeaderText="Category" />
                        <asp:BoundField DataField="subcatnam" HeaderText="Sub Category" />
                        <asp:BoundField DataField="plncst" HeaderText="Cost" />
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
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server"  SelectMethod="disp_rec" TypeName="nsgumtree.clscat"></asp:ObjectDataSource>
                <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="disp_rec" TypeName="nsgumtree.clssubcat">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="DropDownList1" Name="catcod" PropertyName="SelectedValue" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
                <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" SelectMethod="disp_rec" TypeName="nsgumtree.clspln"></asp:ObjectDataSource>
            </td>
        </tr>
    </table>
</asp:Content>

