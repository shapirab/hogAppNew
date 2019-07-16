<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Results.aspx.cs" Inherits="HogApp.Results" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            font-size: xx-large;
        }
        .auto-style2 {
            font-size: xx-large;
        }
        .auto-style3 {
            width: 100%;
        }
        .auto-style4 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style4">
        <div class="auto-style1">
            <h1 class="auto-style2">תחרות בית האלופים</h1>
        </div>
            <table class="auto-style3">
                <tr>
                    <td>
                        <asp:Label ID="lblHouse1" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lblHouse2" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lblHouse3" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lblHouse4" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Image ID="Image1" runat="server" Height="71px" ImageUrl="~/Resources/hourglass1.jpg" Width="113px" />
                    </td>
                    <td>
                        <asp:Image ID="Image2" runat="server" Height="71px" ImageUrl="~/Resources/hourglass1.jpg" Width="113px" />
                    </td>
                    <td>
                        <asp:Image ID="Image3" runat="server" Height="71px" ImageUrl="~/Resources/hourglass1.jpg" Width="113px" />
                    </td>
                    <td>
                        <asp:Image ID="Image4" runat="server" Height="71px" ImageUrl="~/Resources/hourglass1.jpg" Width="113px" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <p>מס&#39; נקודות לבית</p>
                        &nbsp;<asp:Label ID="lblTotalPointsHs1" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td>
                        <p>מס&#39; נקודות לבית</p>
                        <asp:Label ID="lblTotalPointsHs2" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td>
                        <p>מס&#39; נקודות לבית</p>
                        <asp:Label ID="lblTotalPointsHs3" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td>
                        <p>מס&#39; נקודות לבית</p>
                        <asp:Label ID="lblTotalPointsHs4" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblChampion1" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lblChampion2" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lblChampion3" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lblChampion4" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <h2 class="auto-style4">אלוף ביה&quot;ס למוסיקה ע&quot;ש ג&#39;ורג&#39; שייפר</h2>
            <asp:Label ID="lblSchoolChamp" runat="server" CssClass="auto-style2" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
