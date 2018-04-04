<%@ Page Title="" Language="C#" MasterPageFile="~/SM_Master.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="Lab1.Products" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Product Registration</h1>   
    <table>
        <tr>
            <td>
                Select Product ID
            </td>
            <td>
                
    <asp:DropDownList ID="ddlProductID" AutoPostBack="true" runat="server" OnSelectedIndexChanged="ddlProductID_SelectedIndexChanged"></asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Product ID</td>
            <td>
                <asp:TextBox ID="txtProductId" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Product Name </td>
            <td>
                <asp:TextBox ID="txtProductName" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Product Type</td>
            <td>
                <asp:TextBox ID="txtProductType" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Product Description  </td>
            <td>
                <asp:TextBox ID="txtProductDes" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnAddProd" runat="server" Text="Add Product" Height="27px" OnClick="btnAddProd_Click" />
            </td>
            <td>
                <asp:Button ID="btnUpdateProd" runat="server" Text="Update Product" OnClick="btnUpdateProd_Click" />
            </td>
            <td>
                <asp:Button ID="btnDeleteProd" runat="server" Text="Delete Product" OnClick="btnDeleteProd_Click" />
            </td>
        </tr>
    </table>
    <asp:GridView ID="grdProducts" runat="server"></asp:GridView>


</asp:Content>
