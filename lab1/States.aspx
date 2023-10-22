<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="States.aspx.cs" Inherits="Lab1.States" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            color: #FF3300;
        }
        .auto-style2 {
            width: 208px;
        }
        .auto-style3 {
            width: 208px;
            height: 25px;
        }
        .auto-style4 {
            height: 25px;
        }
        .auto-style5 {
            width: 208px;
            height: 105px;
        }
        .auto-style6 {
            height: 105px;
        }
        .auto-style7 {
            width: 208px;
            height: 91px;
        }
        .auto-style8 {
            height: 91px;
        }
        .auto-style12 {
            width: 257px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 class="auto-style1">Three Recommended States</h1>
        </div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style12" rowspan="3">
                    <asp:Panel ID="Panel2" runat="server" Height="120px">
                        <asp:Image ID="stateImage" runat="server" Height="153px" Width="225px" />
                    </asp:Panel>
                </td>
                <td class="auto-style4"></td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Panel ID="StatePanel" runat="server" BackColor="White" BorderStyle="Solid" Height="108px">
                        <asp:RadioButton ID="OregonRadioButton" runat="server" AutoPostBack="True" Font-Names="Arial" ForeColor="#FF3300" GroupName="myGroup" OnCheckedChanged="OregonRadioButton_CheckedChanged" Text="State of Oregon" ToolTip="Oregon" />
                        <br />
                        <asp:RadioButton ID="WashingtonRadioButton" runat="server" AutoPostBack="True" Font-Names="Arial" ForeColor="#FF3300" GroupName="myGroup" OnCheckedChanged="WashingtonRadioButton_CheckedChanged" Text="State of Washington" ToolTip="Washington" />
                        <br />
                        <asp:RadioButton ID="CaliforniaRadioButton" runat="server" AutoPostBack="True" Font-Names="Arial" ForeColor="#FF3300" GroupName="myGroup" OnCheckedChanged="CaliforniaRadioButton_CheckedChanged" Text="State of California" ToolTip="California" />
                        <br />
                        <asp:RadioButton ID="clearRadioButton" runat="server" AutoPostBack="True" Font-Names="Arial" ForeColor="#FF3300" GroupName="myGroup" OnCheckedChanged="clearRadioButton_CheckedChanged" Text="Clear" ToolTip="Clear Everything" />
                        <br />
                    </asp:Panel>
                </td>
                <td class="auto-style6">
                    <asp:TextBox ID="stateTextBox" runat="server" BorderStyle="Solid" Font-Names="Arial" Height="67px" TextMode="MultiLine" ToolTip="Description of State" Width="684px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style8">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style12">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:DropDownList ID="StateDropDownList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="StateDropDownList_SelectedIndexChanged" ToolTip="States Population">
                        <asp:ListItem>States Population</asp:ListItem>
                        <asp:ListItem>Oregon</asp:ListItem>
                        <asp:ListItem>Washington</asp:ListItem>
                        <asp:ListItem>California</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style12">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="firstpageButton" runat="server" OnClick="firstpageButton_Click" Text="First Page" ToolTip="going to the first page" />
                </td>
                <td class="auto-style12">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
