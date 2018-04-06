<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CheckLogin.aspx.cs" Inherits="Lab1.CheckLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/sm.css" rel="stylesheet" />
    </head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td> Username </td>
                <td><asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>

                    <asp:RequiredFieldValidator ControlToValidate="txtUsername" ID="RequiredFieldValidator1" runat="server" ErrorMessage="<span class='ErrorMsg'>*</span>"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td> Password </td>
                <td>
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ControlToValidate="txtPassword" ID="RequiredFieldValidator2" runat="server" ErrorMessage="<span class='ErrorMsg'>*</span>"></asp:RequiredFieldValidator>

                </td>
            </tr>
            <tr>
                <td><asp:Button ID="btnClick" OnClientClick="validateUserInput();" OnClick="btnClick_Click" runat="server" Text="SignIn" /></td>
                <td><asp:Button ID="btnSignUp" runat="server" CausesValidation="false" Text="SignUp" OnClick="btnSignUp_Click" /></td>
            </tr>
        </table>
        <asp:Label ID="errorMessage" runat="server" Text="" style ="color:red"></asp:Label>
    </form>
    <script>
        function validateUserInput() {

           <%-- var username = document.getElementById('<%= txtUsername.ClientID %>').value;
            var username = document.getElementById('<%= txtUsername.ClientID %>').value;
            if (username.length <= 0 )
            {
                alert("Enter User Name");
                return false;
            }--%>

}

    </script>
</body>
</html>
