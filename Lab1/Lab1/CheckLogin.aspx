<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CheckLogin.aspx.cs" Inherits="Lab1.CheckLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td> Username </td>
                <td><asp:TextBox ID="txtUsername" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td> Password </td>
                <td>
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Button ID="btnClick" OnClick="btnClick_Click" runat="server" Text="SignIn" /></td>
                <td><asp:Button ID="btnSignUp" runat="server" Text="SignUp" OnClick="btnSignUp_Click" /></td>
            </tr>
        </table>
        <asp:Label ID="errorMessage" runat="server" Text="" style ="color:red"></asp:Label>
    </form>
</body>
</html>
