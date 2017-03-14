<%@ Page MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="CompSQLDoublesCounter.aspx.cs" Inherits="TypeLess.Components.CompSQLDoublesCounter" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td><asp:Label ID="Label1" runat="server" Text="Table Name"></asp:Label></td>
            <td><asp:TextBox ID="tbName" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Label ID="Label2" runat="server" Text="Field Name"></asp:Label></td>
            <td><asp:TextBox ID="tbField" runat="server"></asp:TextBox></td>
        </tr>
    </table>
    <asp:Button ID="Button1" runat="server" Text="do" OnClick="Button1_Click1" class="btn btn-primary btn-mini" />
    <hr />   
    <pre><asp:Label ID="lblOutput" runat="server" Text="###" BackColor="#FFFFCC"></asp:Label></pre> 
</asp:Content>

