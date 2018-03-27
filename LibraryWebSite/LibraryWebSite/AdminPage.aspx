<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="LibraryWebSite.AdminPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td>UserName</td>
                <td>
                    <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Password</td>
                <td>
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan =" 2">
                    <asp:Button ID="btnLogIn" runat="server" Text="LogIn" OnClick="btnLogIn_Click" /></td>
            </tr>
        </table>
        <asp:Label ID="txtMessage" runat="server" style ="color:red" Text=""></asp:Label>
    </form>
</body>
</html>
