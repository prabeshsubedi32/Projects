<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="LibraryWebSite.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
            <h1> This is the Library HomePage</h1>
            <table>
                <tr>
                    <td> <asp:Button ID="btnBookList" runat="server" Text="List of Books" OnClick="btnBookList_Click" /></td>
                    <td>
                        <asp:Button ID="btnLogin" runat="server" Text="Admin Login" OnClick="btnLogin_Click" /></td>
                </tr>
            </table>
    </form>
</body>
</html>
