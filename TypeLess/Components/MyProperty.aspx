<%@ Page MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="MyProperty.aspx.cs" Inherits="TypeLess.Components.MyProperty" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td><asp:Label ID="Label1" runat="server" Text="Name"></asp:Label></td>
            <td><asp:TextBox ID="tbName" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Label ID="Label3" runat="server" Text="Type"></asp:Label></td>
            <td><asp:TextBox ID="tbType" runat="server"></asp:TextBox></td>
        </tr>
    </table>
    <asp:Button ID="Button1" runat="server" Text="do" OnClick="Button1_Click1" />
    <hr />   
    <pre><asp:Label ID="lblOutput" runat="server" Text="###" BackColor="#FFFFCC"></asp:Label></pre> 
</asp:Content>
