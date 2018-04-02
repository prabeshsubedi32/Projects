<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Lab1.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>This is the home page</h1>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td>
                    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
                   </td>
            </tr>
        </table>
    </form>
</body>
</html>
