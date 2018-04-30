<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addTrack.aspx.cs" Inherits="tracksRecord.addTrack" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Enter Track&#39;s Album&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Enter the Track&#39;s name<br />
        <br />
        <asp:TextBox ID="txtTrackAlbum" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtTrackIn" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnAddTrack" runat="server" OnClick="btnAddTrack_Click" Text="Add Track" />
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnToMain" runat="server" OnClick="btnToMain_Click" Text="Back To Main" />
    
    </div>
    </form>
</body>
</html>
