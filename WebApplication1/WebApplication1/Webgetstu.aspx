<%@ Page Language="C#" MasterPageFile ="~/Site.Master" AutoEventWireup="true" CodeBehind="Webgetstu.aspx.cs" Inherits="WebApplication1.Webgetstu" %>
<asp:Content ID ="myget" ContentPlaceHolderID="MainContent" runat ="server">
    <asp:Label ID ="label1" Text="sid" runat="server"></asp:Label>
    <asp:TextBox ID ="TextBox" runat="server" Text=""></asp:TextBox><br />
    <asp:Button ID ="button1" runat ="server" Text ="getstudent" OnClick="button1_Click" />
         <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </asp:Content>