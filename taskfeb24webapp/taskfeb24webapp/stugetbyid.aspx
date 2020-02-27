<%@ Page Language="C#" MasterPageFile ="~/Site.Master" AutoEventWireup="true" CodeBehind="stugetbyid.aspx.cs" Inherits="taskfeb24webapp.stugetbyid" %>

<asp:Content ID ="getbystuid" ContentPlaceHolderID ="MainContent" runat="server">
    <asp:Label ID ="label1" Text ="sid" runat ="server"></asp:Label><br />
    <asp:TextBox ID ="Textbox" runat="server" Text =""></asp:TextBox><br />
    <asp:Button ID ="button1" runat="server" Text ="Getstudent" OnClick="button1_Click" />
    <asp:GridView ID ="GridView2" runat="server"></asp:GridView>
</asp:Content>
