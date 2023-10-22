<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewUser.aspx.cs" Inherits="Lab5.NewUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 173px;
            background-color: #FFCCCC;
        }
        .auto-style2 {
            width: 173px;
            font-size: large;
            background-color: #FFCCCC;
        }
        .auto-style3 {
            width: 37%;
        }
        .auto-style4 {
            width: 352px;
            background-color: #FFCCCC;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <table style="font-family: Arial, Helvetica, sans-serif; font-size: x-large; background-color: #FF9966;" class="auto-style3">
            <tr>
                <td class="auto-style1" style="font-size: large">User Name</td>
                <td style="font-size: large" class="auto-style4">
                    <asp:TextBox ID="userNameTextBox" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="userNameTextBox" ErrorMessage="User name is required" ForeColor="#FF3300">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1" style="font-size: large">Password</td>
                <td style="font-size: large" class="auto-style4">
                    <asp:TextBox ID="passwordTextBox" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="passwordTextBox" ErrorMessage="password is required" ForeColor="#FF3300">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1" style="font-size: large">Reenter Password</td>
                <td style="font-size: large" class="auto-style4">
                    <asp:TextBox ID="reenterpTextBox" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="reenterpTextBox" ErrorMessage="re enter password" ForeColor="#FF3300">*</asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="passwordTextBox" ControlToValidate="reenterpTextBox" ErrorMessage="Passwords must match" ForeColor="#FF3300"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Email</td>
                <td style="font-size: large" class="auto-style4">
                    <asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="emailTextBox" ErrorMessage="email is required" ForeColor="#FF3300">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="emailTextBox" ErrorMessage="Enter Valid Email" ForeColor="#FF3300" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">State</td>
                <td style="font-size: large" class="auto-style4">
                    <asp:DropDownList ID="stateDropDownList" runat="server">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem>OR</asp:ListItem>
                        <asp:ListItem>WA</asp:ListItem>
                        <asp:ListItem>CA</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="stateDropDownList" ErrorMessage="state is required" ForeColor="#FF3300">*</asp:RequiredFieldValidator>
                </td>
            </tr>
        </table>
        <asp:Button ID="submitButton" runat="server" Text="Submit" OnClick="submitButton_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <input id="Reset1" type="reset" value="reset" /><asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True" ShowSummary="False" />
        <p>
            <asp:LinkButton ID="LinkButton1" runat="server" Font-Size="Large" PostBackUrl="~/Login.aspx">Returning User?</asp:LinkButton>
        </p>
    </form>
</body>
</html>
