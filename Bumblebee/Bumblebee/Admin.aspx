<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="Bumblebee.Admin" %>

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
                    <td>Product id </td>
                    <td><asp:TextBox ID="txtproductid" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Product name</td>
                    <td> <asp:TextBox ID="txtProductname" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Product price</td>
                    <td><asp:TextBox ID="txtproductprice" runat="server"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td>Category Name</td>
                    <td><asp:TextBox ID="txtcategoryname" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td> Brand name</td>
                   <td> <asp:TextBox ID="txtbrandname" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan ="2" align ="center">
                        <asp:Button ID="btninsert" runat="server" Text="Insert" OnClick="Button1_Click" />
                        <asp:Button ID="btndelete" runat="server" Text="Delete" OnClick="Button2_Click" />
                        <asp:Button ID="btnupdate" runat="server" Text="Update" OnClick="Button3_Click" />
                    </td>
                </tr>
            </table>
            <br />
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>