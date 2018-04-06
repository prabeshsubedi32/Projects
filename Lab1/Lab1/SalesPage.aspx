<%@ Page Title="" Language="C#" MasterPageFile="~/SM_Master.Master" AutoEventWireup="true" CodeBehind="SalesPage.aspx.cs" Inherits="Lab1.SalesPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
       <tr>
         <td> Select Product ID
    </td>
           <td>
               <asp:DropDownList ID="ddlProductID" AutoPostBack="true" runat="server" OnSelectedIndexChanged="ddlProductID_SelectedIndexChanged" ></asp:DropDownList>
           </td>
       </tr>
       <tr>
           <td>Product ID</td>
           <td>
               <asp:textbox ID = "txtProductID"  runat="server"></asp:textbox>
           </td>
       </tr>
       <tr>
           <td>Product Name</td>
           <td>
               <asp:textbox ID = "txtProductName"  runat="server"></asp:textbox>
           </td>
       </tr>
       <tr>
           <td>Product Type</td>
           <td>
               <asp:textbox ID = "txtProductType"  runat="server"></asp:textbox>
           </td>
       </tr>
       <tr>
           <td>Product Description</td>
           <td>
               <asp:textbox ID = "txtProductDes"  runat="server"></asp:textbox>
           </td>
       </tr>
       <tr>
           <td>Quantity</td>
           <td>
               <asp:textbox ID = "txtQty"  runat="server"></asp:textbox>
           </td>
           <td> Quantity Available </td>
           <td>
               <asp:TextBox ID="txtTotalQty" runat="server"></asp:TextBox></td>
       </tr>
       <tr>
           <td>Product Price</td>
           <td>
               <asp:textbox ID = "txtPrice"  runat="server"></asp:textbox>
           </td>
           <td>
               <asp:Label ID="lblStock" runat="server" Text=""></asp:Label></td>
       </tr>
        <tr>
            <td>
                <asp:Button ID="btnSales" runat="server" Text="Sale Product" OnClick="btnSales_Click" />
            </td>
        </tr>
   
   </table>

</asp:Content>
