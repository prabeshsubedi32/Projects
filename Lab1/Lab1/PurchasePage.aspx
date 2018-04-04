<%@ Page Title="" Language="C#" MasterPageFile="~/SM_Master.Master" AutoEventWireup="true" CodeBehind="PurchasePage.aspx.cs" Inherits="Lab1.PurchasePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <table>
       <tr>
         <td> Select Product ID
    </td>
           <td>
               <asp:DropDownList ID="ddlProductID" AutoPostBack="true" runat="server" OnSelectedIndexChanged="ddlProductID_SelectedIndexChanged"  ></asp:DropDownList>
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
       </tr>
       <tr>
           <td>Price</td>
           <td>
               <asp:textbox ID = "txtPrice"  runat="server"></asp:textbox>
           </td>
       </tr>
         <tr>
             <td>
                 <asp:Button ID="btnPurchase" runat="server" Text="Purchase Product" OnClick="btnPurchase_Click" />
             </td>
         </tr>
   
   </table>
</asp:Content>
