﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookListControl.aspx.cs" Inherits="LibraryWebSite.BookListControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>Select Book ID</td>
                    <td>
                        <asp:DropDownList ID="ddlBookList" AutoPostBack="true" runat="server" OnSelectedIndexChanged="ddlBookList_SelectedIndexChanged"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>Name of Book</td>
                    <td colspan ="2">
                        <asp:TextBox ID="txtBooksName" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Book ID</td>
                    <td>
                        <asp:TextBox ID="txtBookID" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnAdd" runat="server" Text="Add Books" OnClick="btnAdd_Click" /></td>
                    <td>
                        <asp:Button ID="btnRemove" runat="server" Text="Remove Books" OnClick="btnRemove_Click" /></td>
                    <td colspan="2">
                        <asp:Button ID="btnUpdate" runat="server" Text="Update Books" OnClick="btnUpdate_Click" /></td>
                </tr>
            </table>
            <asp:Button ID="btnBooksList" runat="server" Text="Current List of Books" OnClick="btnBooksList_Click" />
        </div>
        <asp:Label ID="errorText" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
