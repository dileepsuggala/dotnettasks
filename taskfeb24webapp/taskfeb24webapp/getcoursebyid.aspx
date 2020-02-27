<%@ Page Language="C#" MasterPageFile ="~/Site.Master" AutoEventWireup="true" CodeBehind="getcoursebyid.aspx.cs" Inherits="taskfeb24webapp.getcoursebyid" %>
<asp:Content ID ="getbycourseid" ContentPlaceHolderID ="MainContent" runat="server">
    <asp:Label ID ="label1" Text ="cid" runat ="server"></asp:Label><br />
    <asp:TextBox ID ="Textbox" runat="server" Text =""></asp:TextBox><br />
    <asp:Button ID ="button1" runat="server" Text ="Getfaculty" OnClick="button1_Click" />
    <asp:GridView ID ="GridView2" runat="server"></asp:GridView>
</asp:Content>
