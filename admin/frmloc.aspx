<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="frmloc.aspx.cs" Inherits="admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p style="font-size: medium">
        <strong>Locations</strong></p>
    <table class="auto-style1">
        <tr>
            <td style="width: 165px; font-size: medium"><strong>Select Country</strong></td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="ObjectDataSource1" DataTextField="cntnam" DataValueField="cntcod" Height="16px" Width="127px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 165px; font-size: medium"><strong>Enter Location</strong></td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="font-size: medium"><strong>
                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" style="font-size: medium; font-weight: bold" Text="Submit" />
                <span style="font-size: medium">&nbsp; </span>
                
                <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" style="font-weight: bold; font-size: medium" Text="Cancel" />
                
                </strong></td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource2" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" DataKeyNames="loccod">
                    <Columns>
                        <asp:BoundField DataField="locnam" HeaderText="Location" SortExpression="locnam" />
                        <asp:CommandField ShowEditButton="True" />
                        <asp:CommandField ShowDeleteButton="True" />
                    </Columns>
                </asp:GridView>
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="disp_rec" TypeName="nsgumtree.clscnt"></asp:ObjectDataSource>
                <br />
                <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="disp_rec" TypeName="nsgumtree.clsloc">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="DropDownList1" Name="cntcod" PropertyName="SelectedValue" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </td>
        </tr>
    </table>
</asp:Content>

