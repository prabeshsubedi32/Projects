<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="Lab1.SignUp" %>

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
                <td> Select Id</td>
                <td>
                    <asp:DropDownList ID="ddlIds" AutoPostBack="true" runat="server" OnSelectedIndexChanged="ddlIds_SelectedIndexChanged"></asp:DropDownList>

                </td>
            </tr>
            <tr>
                <td> First Name</td>
                <td><asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td> Last Name </td>
                <td>
                    <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox></td>
            </tr>
             <tr>
                <td> UserName</td>
                <td>
                    <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td> Password</td>
                <td>
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox></td>
            </tr>
                 <tr>
                <td> Email</td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    <asp:RegularExpressionValidator ValidationExpression="^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$" ControlToValidate="txtEmail" ID="RegularExpressionValidator1" runat="server" ErrorMessage="RegularExpressionValidator"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td> Phone </td>
                <td>
                    <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox></td>
            </tr>
  <tr>
                <td> User type</td>
                <td>
                    <asp:RadioButtonList ID="rblUsrrType" runat="server">
                        <asp:ListItem Text="User" value="0" />
                          <asp:ListItem Text="Admin" value="1" />
                    </asp:RadioButtonList> </td>
            </tr>

            <tr>
                <td colspan="2"><asp:Button ID="btnSignUp" CausesValidation="" runat="server" Text="SignUp" OnClick="btnSignUp_Click" />
                    <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
<asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
                </td>
            </tr>
        </table>
        </div>
    </form>
</body>
</html>
