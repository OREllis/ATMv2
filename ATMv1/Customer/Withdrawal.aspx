<%@ Page Language="C#" MasterPageFile="~/Customer.master" AutoEventWireup="true" CodeFile="Withdrawal.aspx.cs" Inherits="Customer_Withdrawal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CPHContent" Runat="Server">
    <br />
    <asp:RadioButton ID="rbtn10Pounds" runat="server" OnCheckedChanged="RadioButton1_CheckedChanged" Text="£10" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:RadioButton ID="rbtn50Pounds" runat="server" Text="£50" />
    <br />
    <br />
    <asp:RadioButton ID="rbtn20Pounds" runat="server" Text="£20" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:RadioButton ID="rbtn100Pounds" runat="server" Text="£100" />
    <br />
    <br />
    <asp:RadioButton ID="rbtn30Pounds" runat="server" Text="£30" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:RadioButton ID="rbtn150Pounds" runat="server" Text="£150" />
    <br />
    <br />
    <asp:RadioButton ID="rbtn40Pounds" runat="server" Text="£40" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:RadioButton ID="rbtn250Pounds" runat="server" Text="£250" />
    <br />
    <br />
    <br />
    Enter Amount:&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtAmount" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:CheckBox ID="cbtnAsEuro" runat="server" Text="Withdraw as EURO" />
    <br />
    <br />
    <asp:Button ID="btnEnter" runat="server" OnClick="btnEnter_Click" Text="Continue" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnExit" runat="server" OnClick="btnExit_Click" Text="Exit" Width="77px" />
    <br />
&nbsp;
</asp:Content>
