<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        select subcat<asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" DataSourceID="ObjectDataSource1" DataTextField="catnam" DataValueField="catcod">
        </asp:DropDownList>
    </p>
    <table class="auto-style1">
        <tr>
            <td colspan="2">subcat<asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="ObjectDataSource2" DataTextField="subcatnam" DataValueField="subcatcod">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td colspan="2">item type<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 72px">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="itmtypcod" DataSourceID="ObjectDataSource3" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing">
                    <Columns>
                        <asp:BoundField DataField="itmtypnam" HeaderText="itmtypnam" SortExpression="itmtypnam" />
                        <asp:CommandField ShowEditButton="True" />
                        <asp:CommandField ShowDeleteButton="True" />
                    </Columns>
                </asp:GridView>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 72px">
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="disp_rec" TypeName="nsgumtree.clscat"></asp:ObjectDataSource>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 72px">
                <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="disp_rec" TypeName="nsgumtree.clssubcat">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="DropDownList1" Name="catcod" PropertyName="SelectedValue" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 72px">
                <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" SelectMethod="disp_rec" TypeName="nsgumtree.clsitmtype">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="DropDownList2" Name="subcatcod" PropertyName="SelectedValue" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 72px">
                &nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
                <asp:Button ID="Button2" runat="server" Text="Button" />
            </td>
        </tr>
    </table>
</asp:Content>

