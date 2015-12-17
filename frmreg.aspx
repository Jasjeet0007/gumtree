<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="frmreg.aspx.cs" Inherits="_Default" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
     <a href="frmlog.aspx"><font face="arial" size="+1"><b>Login</b></font></a>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
    <table class="auto-style1">
        <tr>
            <td colspan="2" style="font-size: medium">
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
                <strong>Register Here</strong></td>
        </tr>
        <tr>
            <td style="width: 174px; font-size: medium"><strong>Name</strong></td>
            <td>
                <asp:TextBox ID="txtnam" runat="server" Width="139px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Name Required" ControlToValidate="txtnam" SetFocusOnError="True" BackColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 174px; font-size: medium"><strong>Email</strong></td>
            <td>
                <asp:TextBox ID="txteml" runat="server" Width="138px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Email ID Required" ControlToValidate="txteml" BackColor="Red"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" BackColor="Red" ControlToValidate="txteml" ErrorMessage="Enter Valid Email Id" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 174px; font-size: medium"><strong>Country</strong></td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="ObjectDataSource1" DataTextField="cntnam" DataValueField="cntcod" Height="16px" Width="146px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 174px; font-size: medium"><strong>Location</strong></td>
            <td>
                <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" DataSourceID="ObjectDataSource2" DataTextField="locnam" DataValueField="loccod" Width="145px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 174px; font-size: medium"><strong>Phone</strong></td>
            <td>
                <asp:TextBox ID="txtphn" runat="server" Height="17px" Width="137px"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtphn" ErrorMessage="RegularExpressionValidator" ValidationExpression="^[0-9]{10}"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 174px; font-size: medium"><strong>Password</strong></td>
            <td>
                <asp:TextBox ID="txtpwd" runat="server" Width="138px" TextMode="Password"></asp:TextBox>
                <asp:PasswordStrength ID="txtpwd_PasswordStrength" runat="server" Enabled="True" TargetControlID="txtpwd">
                </asp:PasswordStrength>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtpwd" ErrorMessage="Password Not Entered" BackColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 174px; font-size: medium"><strong>Confirm Password</strong></td>
            <td>
                <asp:TextBox ID="txtcnfpwd" runat="server" Width="139px" TextMode="Password"></asp:TextBox>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Password Mismatch" ValidationGroup="txtcnfpwd" ValueToCompare="txtpwd" ControlToCompare="txtpwd" ControlToValidate="txtcnfpwd" BackColor="Red"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td colspan="2"><strong>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="font-size: medium; font-weight: bold;" Text="Submit" />
                <asp:Button ID="Button2" runat="server" style="font-size: medium; font-weight: bold;" Text="cancel" />
                </strong></td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="Label1" runat="server" ViewStateMode="Disabled"></asp:Label>
                <br />
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="disp_rec" TypeName="nsgumtree.clscnt"></asp:ObjectDataSource>
                <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="disp_rec" TypeName="nsgumtree.clsloc">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="DropDownList1" Name="cntcod" PropertyName="SelectedValue" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
                <br />
            </td>
        </tr>
    </table>
</asp:Content>

