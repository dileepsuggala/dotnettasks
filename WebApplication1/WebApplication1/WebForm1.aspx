<%@ Page Language="C#"MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<asp:Content ID ="myid" ContentPlaceHolderID ="MainContent" runat ="server">
    <asp:Label ID ="label1" Text="sid" runat="server"></asp:Label><br />
    <asp:TextBox ID ="TextBox" runat="server" Text=""></asp:TextBox><br />
        <asp:Label ID ="label2" Text="name" runat="server"></asp:Label><br />
    <asp:TextBox ID ="TextBox1" runat="server" Text=""></asp:TextBox><br />
        <asp:Label ID ="label3" Text="course" runat="server"></asp:Label><br />
    <asp:TextBox ID ="TextBox2" runat="server" Text=""></asp:TextBox><br />
        <asp:Label ID ="label4" Text="start date" runat="server"></asp:Label><br />
    <asp:TextBox ID ="TextBox3" runat ="server" Text =""></asp:TextBox><br />
    <asp:Button ID ="button1" runat ="server" Text ="insert data" OnClick="button1_Click" />
         <asp:GridView ID="GridView1" runat="server"></asp:GridView>
</asp:Content>
