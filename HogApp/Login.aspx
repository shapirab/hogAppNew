<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="HogApp.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            font-size: xx-large;
        }
        .auto-style3 {
            width: 100%;
        }
        .auto-style4 {
            width: 325px;
        }
        .auto-style5 {
            width: 195px;
        }
        .auto-style6 {
            width: 325px;
            text-align: right;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong><span class="auto-style2">Welcome to The George Schaeffer School of Music House Points Software</span><br class="auto-style2" />
            <br class="auto-style2" />
            <span class="auto-style2">Faculty Login Page</span></strong></div>
        <table class="auto-style3">
            <tr>
                <td class="auto-style6">UserName</td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtBoxUserName" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">Password</td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtBoxPassword" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">
                    <asp:Button ID="btnLogin" runat="server" Text="Login" Width="119px" OnClick="btnLogin_Click" />
                </td>
                <td>
                    <asp:Label ID="lbError" runat="server" ForeColor="Red" Text="User Name or Password not valid" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
