<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MySingleton.aspx.cs" Inherits="TypeLess.MySingleton" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td><asp:Label ID="Label1" runat="server" Text="Class Name"></asp:Label></td>
            <td><asp:TextBox ID="TextBox1" style="margin-left: 5px;" runat="server"></asp:TextBox></td>
        </tr>
    </table>
    <asp:Button ID="Button1" runat="server" Text="create" OnClick="Button1_Click1" class="btn btn-primary btn-mini" />
    <hr />   
    <pre><asp:Label ID="Label2" runat="server" Text="###" BackColor="#FFFFCC"></asp:Label></pre> 
</asp:Content>

