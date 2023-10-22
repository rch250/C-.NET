<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Lab1.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            color: #FFFFFF;
            background-color: #FF3300;
        }
        .auto-style2 {
            width: 298px;
        }
        .auto-style3 {
            width: 100%;
            height: 322px;
        }
        .auto-style4 {
            width: 298px;
            height: 230px;
        }
        .auto-style5 {
            height: 230px;
        }
        .auto-style6 {
            width: 298px;
            height: 39px;
        }
        .auto-style7 {
            height: 39px;
        }
        .auto-style8 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 class="auto-style1">Your Favorite States</h1>
        </div>
        <table class="auto-style3">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label1" runat="server" Font-Names="Arial" Text="Enter Your Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="nameTextBox" runat="server" ToolTip="You Must be a client"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label2" runat="server" Font-Names="Arial" Text="Enter Your Password"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="passwordTextBox" runat="server" TextMode="Password" ToolTip="Enter a valid password"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;
                    <asp:Panel ID="buttonPanel" runat="server" BackColor="Yellow">
                        <asp:Button ID="loginButton" runat="server" OnClick="loginButton_Click" Text="Login" ToolTip="Click to log in" Width="47px" />
                        &nbsp;<asp:Button ID="clearButton" runat="server" OnClick="clearButton_Click" Text="Clear" ToolTip="Click to clear the page" />
                        &nbsp;<asp:Button ID="nextPageButton" runat="server" OnClick="nextPageButton_Click" Text="Next" ToolTip="Cick to go to next page" Visible="False" />
                    </asp:Panel>
                </td>
                <td class="auto-style5">
                    <asp:Image ID="loginImage" runat="server" Height="139px" Width="143px" />
                    <br />
                    <asp:Label ID="imageLabel" runat="server" Font-Names="Arial" Text="Picture" ToolTip="Image of User" Visible="False"></asp:Label>
                </td>
                <td class="auto-style5"></td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:CheckBox ID="LoginCheckBox" runat="server" AutoPostBack="True" Font-Names="Arial" OnCheckedChanged="LoginCheckBox_CheckedChanged" Text="Check to see info about the next page" Visible="False" />
                </td>
                <td class="auto-style7">
                    <asp:Label ID="checkBoxLabel" runat="server" BackColor="Aqua" Font-Names="Arial" Text="The next page will allow you to view information on the states that you would like to visit" Visible="False"></asp:Label>
                </td>
                <td class="auto-style7"></td>
            </tr>
        </table>
    </form>
</body>
</html>
