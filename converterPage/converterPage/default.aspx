<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="converterPage._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 441px;
            height: 139px;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            width: 191px;
        }
        .auto-style4 {
            width: 235px;
        }
        .auto-style5 {
            width: 182px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <img alt="" class="auto-style1" src="file:///H:/HNC_SoftDev/Block3/Event%20Driven%20Programming/converterPage/banner.png" /></div>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <p>
&nbsp;&nbsp;&nbsp;
            <table class="auto-style2">
                <tr>
                    <td class="auto-style3">
                        <asp:Button ID="btnConvUpp" runat="server" Text="Convert from Lower to Upper" OnClick="btnConvUpp_Click" />
                    </td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtConvUpp" runat="server" Width="266px"></asp:TextBox>
                    </td>
                    <td class="auto-style5">
                        <asp:Label ID="lblUpp" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Button ID="btnConvLow" runat="server" Text="Convert from upper to lower" />
                    </td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtConvLow" runat="server" Width="266px"></asp:TextBox>
                    </td>
                    <td class="auto-style5">
                        <asp:Label ID="lblLow" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Button ID="btnConvHex" runat="server" Text="Convert to Hex" OnClick="btnConvHex_Click" />
                    </td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtConvHex" runat="server" Width="266px"></asp:TextBox>
                    </td>
                    <td class="auto-style5">
                        <asp:Label ID="lblHex" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Button ID="btnConvBin" runat="server" OnClick="btnConvBin_Click" Text="Convert to Binary" />
                    </td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtConvBin" runat="server" Width="266px"></asp:TextBox>
                    </td>
                    <td class="auto-style5">
                        <asp:Label ID="lblBin" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Button ID="btnConvOct" runat="server" Text="Convert to octal" OnClick="btnConvOct_Click" />
                    </td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtConvOct" runat="server" Width="266px"></asp:TextBox>
                    </td>
                    <td class="auto-style5">
                        <asp:Label ID="lblOct" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Button ID="btnGarb" runat="server" Text="Convert to Garbage" />
                    </td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtGarb" runat="server" Width="266px"></asp:TextBox>
                    </td>
                    <td class="auto-style5">
                        <asp:Label ID="blbGarb" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
            </table>
        </p>
    </form>
</body>
</html>
