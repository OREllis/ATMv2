<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="tracksRecord._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1 style="text-align: center">Welcome, Please select a button to continue</h1>
        <p style="text-align: center">
            <asp:Image ID="Image1" runat="server" />
        </p>
    
    </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="btnFindTrack" runat="server" OnClick="btnFindTrack_Click" Text="Search for a track" Width="200px" />
                </td>
                <td class="auto-style2">
                    <asp:Button ID="findAlbum" runat="server" OnClick="findAlbum_Click" Text="Search for an Album" Width="200px" />
                </td>
                <td class="auto-style2">
                    <asp:Button ID="btnTrackAdd" runat="server" OnClick="btnTrackAdd_Click" Text="Add a track" Width="200px" />
                </td>
                <td class="auto-style2">
                    <asp:Button ID="btnAddAlbum" runat="server" OnClick="btnAddAlbum_Click" Text="Add an Album" Width="200px" />
                </td>
                <td class="auto-style2">
                    <asp:Button ID="btnDelTrack" runat="server" OnClick="btnDelTrack_Click" Text="Delete Track" Width="200px" />
                </td>
                <td class="auto-style2">
                    <asp:Button ID="btnDelAlbum" runat="server" OnClick="btnDelAlbum_Click" Text="Delete Album" Width="200px" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
