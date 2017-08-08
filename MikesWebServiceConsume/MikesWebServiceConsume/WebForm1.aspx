<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="MikesWebServiceConsume.WebForm1" %>


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
            <td>ID</td>
            <td><asp:TextBox runat="server" ID="txtID"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Name</td>
            <td><asp:TextBox runat="server" ID="txtName"></asp:TextBox></td>
        </tr>
        <tr>
            <td>City</td>
            <td><asp:TextBox runat="server" ID="txtCity"></asp:TextBox></td>
        </tr>

    </table>
        <asp:Label runat="server" id="lblMessage">
        </asp:Label>
        <asp:Button runat="server" ID="btnInsert" OnClick="btnInsert_Click" Text="Insert" />
        <asp:Button runat="server" ID="btnUpdate" OnClick="btnUpdate_Click" Text="Update" />
        <asp:Button runat="server" ID="btnDelete" OnClick="btnDelete_Click" Text="Delete" />
        <asp:Button runat="server" ID="btnSelect" OnClick="btnSelect_Click" Text="Select" />
    </div>
    </form>
</body>
</html>
