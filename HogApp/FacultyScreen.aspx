<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FacultyScreen.aspx.cs" Inherits="HogApp.FacultyScreen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 23%;
        }
        .auto-style2 {
            width: 264px;
        }
        .auto-style3 {
            width: 54px;
        }
        .auto-style4 {
            margin-top: 0px;
        }
        .auto-style5 {
            width: 264px;
            height: 141px;
        }
        .auto-style6 {
            width: 54px;
            height: 141px;
        }
        .auto-style7 {
            height: 141px;
        }
    </style>
</head>
<body style="height: 276px">
    <form id="form1" runat="server">
        <div>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:HogDBConnectionString %>" SelectCommand="SELECT * FROM [Students]"></asp:SqlDataSource>
            <br />

            <br />
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtPartialName" runat="server"></asp:TextBox>
                     </td>
                    <td></td>
                    <td class="auto-style2">
                        <asp:Button ID="btnGetStudFromPar" runat="server" Height="31px" OnClick="btnGetStudFromPar_Click" 
                            Text="Click to Get a List of Students" Width="258px" />
                    </td>

                </tr>
                <tr>


                    <td class="auto-style5">&nbsp;
                        <asp:ListBox ID="lbFullNamesByPartial" runat="server" OnSelectedIndexChanged="studentLb_SelectedIndexChanged" Height="121px" Width="204px"></asp:ListBox>

                    </td>
                    <td class="auto-style6">&nbsp;
                        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="+" Height="68px" Width="38px" CssClass="auto-style4"/>
                        &nbsp;
                        
                    </td>
                    <td class="auto-style7">
                        <asp:Button ID="btnSub" runat="server" OnClick="btnSub_Click" Text="-" CssClass="auto-style4" Height="68px" Width="38px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;
                        
                    </td>
                    <td class="auto-style3">&nbsp;
                        <asp:Button ID="btnLogout" runat="server" OnClick="btnLogout_Click" Text="Logout" />
                    </td>
                </tr>
            </table>
            <br />
        </div>
        &nbsp;
&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;
        <br />
        <br />
        <br />
        <br />
        <br />

    </form>
</body>
</html>
