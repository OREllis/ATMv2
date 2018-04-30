<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="delTrack.aspx.cs" Inherits="tracksRecord.delTrack" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Enter Album Track is in&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Enter Track to Delete<br />
        <asp:TextBox ID="txtTrackAlbum" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtTrackToDel" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnDelTrack" runat="server" OnClick="btnDelTrack_Click" Text="Delete Track" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnBack" runat="server" Text="Back to Menu" />
    
    </div>
    </form>
</body>
</html>
