<%@ Page Title="" Language="C#" MasterPageFile="~/SM_Master.Master" AutoEventWireup="true" CodeBehind="ReportPage.aspx.cs" Inherits="Lab1.ReportPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
            <tr>
                <td>
                    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
                   </td>
            </tr>
        </table>
</asp:Content>
