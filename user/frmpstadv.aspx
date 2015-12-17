<%@ Page Title="" Language="C#" MasterPageFile="~/user/MasterPage.master" AutoEventWireup="true" CodeFile="frmpstadv.aspx.cs" Inherits="user_Default" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="0" BackColor="Black" ForeColor="Black" Height="430px" Width="670px" Font-Bold="True" Font-Names="Book Antiqua">
        <asp:TabPanel runat="server" HeaderText="Basic Detail" ID="TabPanel1">
            <ContentTemplate>


                <table class="auto-style1">
                    <tr>
                        <td style="width: 116px; font-size: medium"><strong>Advertisement Title</strong></td>
                        <td>
                            <asp:TextBox ID="txtadvtit" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 116px; font-size: medium"><strong>Select Category</strong></td>
                        <td>
                            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="ObjectDataSource1" DataTextField="catnam" DataValueField="catcod">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 116px; font-size: medium"><strong>Select Subcategory</strong></td>
                        <td>
                            <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="ObjectDataSource2" DataTextField="subcatnam" DataValueField="subcatcod">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 116px; font-size: medium"><strong>Select Item Type</strong></td>
                        <td>
                            <asp:DropDownList ID="DropDownList3" runat="server" DataSourceID="ObjectDataSource3" DataTextField="itmtypnam" DataValueField="itmtypcod">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 116px; font-size: medium"><strong>Description</strong></td>
                        <td>
                            <asp:TextBox ID="txtdsc" runat="server" Height="56px" TextMode="MultiLine" Width="396px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 116px; font-size: medium"><strong>Price</strong></td>
                        <td>
                            <asp:TextBox ID="txtprc" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 116px; font-size: medium"><strong>
                            <asp:Button ID="Button1" runat="server" style="font-weight: bold; font-size: medium" Text="Submit" OnClick="Button1_Click" />
                            </strong></td>
                        <td><strong>
                            <asp:Button ID="Button2" runat="server" style="font-weight: bold; font-size: medium" Text="Cancel" />
                            </strong>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 116px; font-size: medium">&nbsp;</td>
                        <td>
                            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="disp_rec" TypeName="nsgumtree.clscat"></asp:ObjectDataSource>
                            <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="disp_rec" TypeName="nsgumtree.clssubcat">
                                <SelectParameters>
                                    <asp:ControlParameter ControlID="DropDownList1" Name="catcod" PropertyName="SelectedValue" Type="Int32" />
                                </SelectParameters>
                            </asp:ObjectDataSource>
                            <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" SelectMethod="disp_rec" TypeName="nsgumtree.clsitmtype">
                                <SelectParameters>
                                    <asp:ControlParameter ControlID="DropDownList2" ConvertEmptyStringToNull="False" Name="subcatcod" PropertyName="SelectedValue" Type="Int32" />
                                </SelectParameters>
                            </asp:ObjectDataSource>
                        </td>
                    </tr>
                </table>


            </ContentTemplate>
        </asp:TabPanel>
        <asp:TabPanel ID="TabPanel2" runat="server" HeaderText="Pictures">
            <ContentTemplate>

                <table class="auto-style1">
                    <tr>
                        <td style="width: 178px; font-size: medium"><strong>Upload</strong></td>
                        <td><strong>&nbsp;</strong><asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" Font-Bold="True" Font-Size="Medium" Width="127px">
                            <asp:ListItem Value="P">Picture</asp:ListItem>
                            <asp:ListItem Value="V">Video</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 178px; font-size: medium"><strong>Browse File</strong></td>
                        <td>
                            <asp:FileUpload ID="FileUpload1" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 178px; font-size: medium"><strong>Description</strong></td>
                        <td>
                            <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine" Width="207px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" style="font-size: medium"><strong>
                            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" style="font-size: medium; font-weight: bold" Text="Submit" />
                            <asp:Button ID="Button4" runat="server" style="font-size: medium; font-weight: bold" Text="Cancel" />
                            </strong></td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:DataList ID="DataList1" runat="server">
                            </asp:DataList>
                        </td>
                    </tr>
                </table>

            </ContentTemplate>
        </asp:TabPanel>
    </asp:TabContainer>
</asp:Content>

