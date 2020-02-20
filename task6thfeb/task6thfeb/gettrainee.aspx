<%@ Page Language="C#" MasterPageFile ="~/Site.Master" AutoEventWireup="true" CodeBehind="gettrainee.aspx.cs" Inherits="task6thfeb.gettrainee" %>


   <asp:Content ID ="mygettrainee" ContentPlaceHolderID="MainContent" runat ="server">
    <asp:Label ID ="label1" Text="Id" runat="server"></asp:Label>
    <asp:TextBox ID ="TextBox" runat="server" Text=""></asp:TextBox><br />
    <asp:Button ID ="button1" runat ="server" Text ="gettrainee" OnClick="button1_Click" />
         <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </asp:Content>
