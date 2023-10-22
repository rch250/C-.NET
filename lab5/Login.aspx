<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Lab5.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 260px;
            background-color: #FFCC99;
        }
        .auto-style2 {
            width: 260px;
            font-family: Arial, Helvetica, sans-serif;
            font-size: large;
            text-align: right;
            background-color: #FFCC99;
        }
        .auto-style3 {
            width: 260px;
            font-size: large;
            text-align: right;
            background-color: #FFCC99;
        }
        .auto-style5 {
            width: 260px;
            font-size: xx-large;
            text-align: center;
            background-color: #FFFFFF;
            font-family: Arial, Helvetica, sans-serif;
            height: 83px;
            color: #33CCFF;
        }
        .auto-style6 {
            width: 260px;
            font-size: x-large;
            text-align: left;
            background-color: #FFCC99;
        }
        .auto-style8 {
            width: 38%;
        }
        .auto-style9 {
            height: 83px;
            width: 307px;
            background-color: #FF9966;
        }
        .auto-style10 {
            width: 307px;
            background-color: #FFCC99;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style8">
            <tr>
                <td class="auto-style5">Login</td>
                <td style="font-family: Arial, Helvetica, sans-serif; font-size: 12px; " class="auto-style9"></td>
            </tr>
            <tr>
                <td class="auto-style6" style="font-family: Arial, Helvetica, sans-serif; ">RETURNING USER</td>
                <td style="font-family: Arial, Helvetica, sans-serif; font-size: 12px; " class="auto-style10">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3" style="font-family: Arial, Helvetica, sans-serif; ">EMAIL</td>
                <td style="font-family: Arial, Helvetica, sans-serif; font-size: 12px; " class="auto-style10">
                    <asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="emailTextBox" ErrorMessage="email is required" Font-Size="X-Large" ForeColor="#FF3300">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="emailTextBox" ErrorMessage="Enter valid email" Font-Size="Large" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">  </asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">PASSWORD</td>
                <td style="font-family: Arial, Helvetica, sans-serif; font-size: 12px; " class="auto-style10">
                    <asp:TextBox ID="passwordTextBox" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="passwordTextBox" ErrorMessage="password is required" Font-Size="X-Large" ForeColor="#FF3300">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1" style="font-family: Arial, Helvetica, sans-serif; font-size: 12px; ">
                    <asp:CheckBox ID="rememberCheckBox" runat="server" Font-Size="X-Large" Text="Remember Me?" OnCheckedChanged="rememberCheckBox_CheckedChanged" />
                </td>
                <td style="font-family: Arial, Helvetica, sans-serif; font-size: 12px; " class="auto-style10">
                    <br />
                    \<asp:Image ID="rememberImage" runat="server" Width="109px" />
                </td>
            </tr>
        </table>
        <asp:Button ID="submitButton" runat="server" Text="Submit" OnClick="submitButton_Click" Font-Size="Large" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <input id="Reset1" type="reset" value="reset" style="font-size: large" /><br />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True" ShowSummary="False" />
        <p>
        <asp:LinkButton ID="LinkButton1" runat="server" Font-Size="Large" PostBackUrl="~/NewUser.aspx">New User?</asp:LinkButton>
        </p>
    </form>
</body>
</html>
