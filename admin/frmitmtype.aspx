<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="frmitmtype.aspx.cs" Inherits="admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td style="width: 169px; font-size: medium">Select Category</td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="ObjectDataSource1" DataTextField="catnam" DataValueField="catcod" Width="131px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 169px; font-size: medium">Select Subcategory</td>
            <td>
                <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" DataSourceID="ObjectDataSource2" DataTextField="subcatnam" DataValueField="subcatcatcod" style="margin-right: 3px" Width="130px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 169px; font-size: medium">Enter Item Type</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2"><strong>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="font-weight: bold; font-size: medium" Text="Submit" />
                <asp:Button ID="Button2" runat="server" style="font-weight: bold; font-size: medium" Text="Cancel" />
                </strong></td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="itmtypcod" DataSourceID="ObjectDataSource3" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" Width="324px">
                    <Columns>
                        <asp:BoundField DataField="itmtypnam" HeaderText="itmtypnam" SortExpression="itmtypnam" />
                        <asp:CommandField ShowEditButton="True" />
                        <asp:CommandField ShowDeleteButton="True" />
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="disp_rec" TypeName="nsgumtree.clscat"></asp:ObjectDataSource>
                <br />
                <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="disp_rec" TypeName="nsgumtree.clssubcat">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="DropDownList1" Name="catcod" PropertyName="SelectedValue" Type="Int32" ConvertEmptyStringToNull="False" />
                    </SelectParameters>
                </asp:ObjectDataSource>
                <br />
                <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" SelectMethod="disp_rec" TypeName="nsgumtree.clsitmtype">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="DropDownList2" Name="subcatcod" PropertyName="SelectedValue" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </td>
        </tr>
    </table>
</asp:Content>

