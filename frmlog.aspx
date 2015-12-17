<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="frmlog.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
     <a href="frmreg.aspx"><font face="arial" size="+1"><b>Register Here</b></font></a>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p style="font-size: medium">
        <strong>&nbsp;</strong><asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
</p>
    <table class="auto-style1">
        <tr>
            <td style="width: 166px; font-size: medium"><strong>Login ID</strong></td>
            <td>
                <asp:TextBox ID="txteml" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txteml" ErrorMessage="Email id not entered" SetFocusOnError="True"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 166px; font-size: medium"><strong>Password</strong></td>
            <td>
                <asp:TextBox ID="txtpwd" runat="server" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtpwd" ErrorMessage="Password not entered" SetFocusOnError="True"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="font-size: medium"><strong>
                <asp:Button ID="Button1" runat="server" style="font-size: medium; font-weight: bold" Text="Login" OnClick="Button1_Click" />
                <asp:Button ID="Button2" runat="server" style="font-size: medium; font-weight: bold" Text="Cancel" />
                </strong></td>
        </tr>
        <tr>
            <td colspan="2" style="font-size: medium">
                <asp:Label ID="Label1" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>

